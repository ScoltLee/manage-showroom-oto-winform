using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;
using AlertBox;

namespace QLShowRoomOto_MaiLeDuan
{
    public partial class frm_PhanHoi : MaterialForm
    {
        OpenFileDialog ofdAttachment;
        String fileName = "";
        LOPDUNGCHUNG chung;
        public frm_PhanHoi()
        {
            chung = new LOPDUNGCHUNG();
            InitializeComponent();
            timer1.Start();
            chung.GiaoDien(this);
            this.ActiveControl = tb_Email;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment = new OpenFileDialog();
                ofdAttachment.Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf";
                if (ofdAttachment.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofdAttachment.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //Smpt Client Details
                //gmail >> smtp server : smtp.gmail.com, port : 587 , ssl required
                //yahoo >> smtp server : smtp.mail.yahoo.com, port : 587 , ssl required
                btn_Gui.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32(txtPortNumber.Text.Trim());
                clientDetails.Host = txtSmtpServer.Text.Trim();
                clientDetails.EnableSsl = cb_SSL.Checked;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(tb_Email.Text.Trim(), tb_MK.Text.Trim());

                //Message Details
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(tb_Email.Text.Trim());
                mailDetails.To.Add(txtRecipientEmail.Text.Trim());
                //for multiple recipients
                //mailDetails.To.Add("another recipient email address");
                //for bcc
                //mailDetails.Bcc.Add("bcc email address")
                mailDetails.Subject = tb_ChuDe.Text.Trim();
                mailDetails.IsBodyHtml = cb_HTML.Checked;
                mailDetails.Body = tb_NoiDung.Text.Trim();


                //file attachment
                if (fileName.Length > 0)
                {
                    Attachment attachment = new Attachment(fileName);
                    mailDetails.Attachments.Add(attachment);
                }

                clientDetails.Send(mailDetails);
                this.TopMost = false;
                chung.Alert("Gửi email thành công.", frm_Alert.enmType.Success);
                fileName = "";

            }
            catch (Exception ex)
            {
                this.TopMost = false;
                chung.Alert("Lỗi xác thực, xem hướng dẫn và thử lại.", frm_Alert.enmType.Error);

            }
            btn_Gui.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 105)
            {
                timer1.Stop();
                updateUI();
            }
        }

        private void updateUI()
        {

            lb_PH.Visible = true;
            btn_Them.Visible = true;
            btn_Gui.Visible = true;
            progressBar1.Visible = false;
            lb_ChuDe.Visible = true;
            tb_ChuDe.Visible = true;
            lb_TDK.Visible = true;
            lb_NguoiNhan.Visible = true;
            txtRecipientEmail.Visible = true;
            lb_PH.Visible = true;
            lb_MatKhau.Visible = true;
            tb_Email.Visible = true;
            lb_Email.Visible = true;
            lb_SMTP.Visible = true;
            lb_Port.Visible = true;
            tb_MK.Visible = true;
            txtSmtpServer.Visible = true;
            txtPortNumber.Visible = true;
            cb_SSL.Visible = true;
            tb_NoiDung.Visible = true;
            lb_NoiDung.Visible = true;
            cb_HTML.Visible = true;
            lb_HuongDan.Visible = true;
            lnb_Link.Visible = true;
            cb_HienThi.Visible = true;
        }

        private void lnb_FB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://vn.ultramailer.org/page/104-xu-ly-loi-5-7-0-authentication-required-moi-nhat-khi-gui-email-hang-loat-qua-hom-gmail.html");
            this.TopMost = false;
        }

        private void frm_PhanHoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["frm_Main"].Activate();
        }

        private void cb_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_HienThi.Checked == true)
            {
                tb_MK.UseSystemPasswordChar = false;
            }
            else
            {
                tb_MK.UseSystemPasswordChar = true;
            }
        }
    }
}

