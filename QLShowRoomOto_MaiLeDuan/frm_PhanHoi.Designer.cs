
namespace QLShowRoomOto_MaiLeDuan
{
    partial class frm_PhanHoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_ChuDe = new System.Windows.Forms.Label();
            this.tb_ChuDe = new System.Windows.Forms.TextBox();
            this.lb_TDK = new System.Windows.Forms.Label();
            this.lb_NguoiNhan = new System.Windows.Forms.Label();
            this.txtRecipientEmail = new System.Windows.Forms.TextBox();
            this.lb_PH = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new CircularProgressBar();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_SMTP = new System.Windows.Forms.Label();
            this.lb_Port = new System.Windows.Forms.Label();
            this.tb_MK = new System.Windows.Forms.TextBox();
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.cb_SSL = new System.Windows.Forms.CheckBox();
            this.tb_NoiDung = new System.Windows.Forms.RichTextBox();
            this.lb_NoiDung = new System.Windows.Forms.Label();
            this.btn_Them = new MaterialSkin.Controls.MaterialButton();
            this.btn_Gui = new MaterialSkin.Controls.MaterialButton();
            this.cb_HTML = new System.Windows.Forms.CheckBox();
            this.lnb_Link = new System.Windows.Forms.LinkLabel();
            this.lb_HuongDan = new System.Windows.Forms.Label();
            this.cb_HienThi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_ChuDe
            // 
            this.lb_ChuDe.AutoSize = true;
            this.lb_ChuDe.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChuDe.Location = new System.Drawing.Point(101, 350);
            this.lb_ChuDe.Name = "lb_ChuDe";
            this.lb_ChuDe.Size = new System.Drawing.Size(66, 19);
            this.lb_ChuDe.TabIndex = 0;
            this.lb_ChuDe.Text = "Chủ đề :";
            this.lb_ChuDe.Visible = false;
            // 
            // tb_ChuDe
            // 
            this.tb_ChuDe.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ChuDe.Location = new System.Drawing.Point(184, 347);
            this.tb_ChuDe.Name = "tb_ChuDe";
            this.tb_ChuDe.Size = new System.Drawing.Size(263, 27);
            this.tb_ChuDe.TabIndex = 1;
            this.tb_ChuDe.Visible = false;
            // 
            // lb_TDK
            // 
            this.lb_TDK.AutoSize = true;
            this.lb_TDK.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TDK.Location = new System.Drawing.Point(61, 393);
            this.lb_TDK.Name = "lb_TDK";
            this.lb_TDK.Size = new System.Drawing.Size(106, 19);
            this.lb_TDK.TabIndex = 0;
            this.lb_TDK.Text = "Tệp đính kèm:";
            this.lb_TDK.Visible = false;
            // 
            // lb_NguoiNhan
            // 
            this.lb_NguoiNhan.AutoSize = true;
            this.lb_NguoiNhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NguoiNhan.Location = new System.Drawing.Point(31, 308);
            this.lb_NguoiNhan.Name = "lb_NguoiNhan";
            this.lb_NguoiNhan.Size = new System.Drawing.Size(136, 19);
            this.lb_NguoiNhan.TabIndex = 0;
            this.lb_NguoiNhan.Text = "Email người nhận :";
            this.lb_NguoiNhan.Visible = false;
            // 
            // txtRecipientEmail
            // 
            this.txtRecipientEmail.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipientEmail.Location = new System.Drawing.Point(184, 305);
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(263, 27);
            this.txtRecipientEmail.TabIndex = 1;
            this.txtRecipientEmail.Text = "maileduan24899@gmail.com";
            this.txtRecipientEmail.Visible = false;
            // 
            // lb_PH
            // 
            this.lb_PH.AutoSize = true;
            this.lb_PH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PH.ForeColor = System.Drawing.Color.Red;
            this.lb_PH.Location = new System.Drawing.Point(294, 49);
            this.lb_PH.Name = "lb_PH";
            this.lb_PH.Size = new System.Drawing.Size(238, 24);
            this.lb_PH.TabIndex = 27;
            this.lb_PH.Text = "PHẢN HỒI QUA EMAIL";
            this.lb_PH.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BarColor1 = System.Drawing.Color.Orange;
            this.progressBar1.BarColor2 = System.Drawing.Color.Orange;
            this.progressBar1.BarWidth = 14F;
            this.progressBar1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.progressBar1.LineColor = System.Drawing.Color.Transparent;
            this.progressBar1.LineWidth = 0;
            this.progressBar1.Location = new System.Drawing.Point(360, 148);
            this.progressBar1.Maximum = ((long)(100));
            this.progressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(130, 130);
            this.progressBar1.TabIndex = 25;
            this.progressBar1.Text = "0";
            this.progressBar1.Value = ((long)(0));
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhau.Location = new System.Drawing.Point(87, 148);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(80, 19);
            this.lb_MatKhau.TabIndex = 0;
            this.lb_MatKhau.Text = "Mật khẩu :";
            this.lb_MatKhau.Visible = false;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(184, 110);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(263, 27);
            this.tb_Email.TabIndex = 1;
            this.tb_Email.Visible = false;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(109, 113);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(58, 19);
            this.lb_Email.TabIndex = 0;
            this.lb_Email.Text = "Email :";
            this.lb_Email.Visible = false;
            // 
            // lb_SMTP
            // 
            this.lb_SMTP.AutoSize = true;
            this.lb_SMTP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SMTP.Location = new System.Drawing.Point(68, 209);
            this.lb_SMTP.Name = "lb_SMTP";
            this.lb_SMTP.Size = new System.Drawing.Size(99, 19);
            this.lb_SMTP.TabIndex = 0;
            this.lb_SMTP.Text = "Smtp server :";
            this.lb_SMTP.Visible = false;
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Port.Location = new System.Drawing.Point(64, 246);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(103, 19);
            this.lb_Port.TabIndex = 0;
            this.lb_Port.Text = "Port number :";
            this.lb_Port.Visible = false;
            // 
            // tb_MK
            // 
            this.tb_MK.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MK.Location = new System.Drawing.Point(184, 145);
            this.tb_MK.Name = "tb_MK";
            this.tb_MK.Size = new System.Drawing.Size(263, 27);
            this.tb_MK.TabIndex = 2;
            this.tb_MK.UseSystemPasswordChar = true;
            this.tb_MK.Visible = false;
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtpServer.Location = new System.Drawing.Point(184, 206);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.ReadOnly = true;
            this.txtSmtpServer.Size = new System.Drawing.Size(263, 27);
            this.txtSmtpServer.TabIndex = 3;
            this.txtSmtpServer.Text = "smtp.gmail.com";
            this.txtSmtpServer.Visible = false;
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortNumber.Location = new System.Drawing.Point(184, 243);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.ReadOnly = true;
            this.txtPortNumber.Size = new System.Drawing.Size(263, 27);
            this.txtPortNumber.TabIndex = 4;
            this.txtPortNumber.Text = "587";
            this.txtPortNumber.Visible = false;
            // 
            // cb_SSL
            // 
            this.cb_SSL.AutoSize = true;
            this.cb_SSL.Checked = true;
            this.cb_SSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_SSL.Enabled = false;
            this.cb_SSL.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SSL.Location = new System.Drawing.Point(184, 276);
            this.cb_SSL.Name = "cb_SSL";
            this.cb_SSL.Size = new System.Drawing.Size(56, 23);
            this.cb_SSL.TabIndex = 5;
            this.cb_SSL.Text = "SSL";
            this.cb_SSL.UseVisualStyleBackColor = true;
            this.cb_SSL.Visible = false;
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NoiDung.Location = new System.Drawing.Point(496, 145);
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tb_NoiDung.Size = new System.Drawing.Size(298, 229);
            this.tb_NoiDung.TabIndex = 1;
            this.tb_NoiDung.Text = "";
            this.tb_NoiDung.Visible = false;
            // 
            // lb_NoiDung
            // 
            this.lb_NoiDung.AutoSize = true;
            this.lb_NoiDung.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoiDung.Location = new System.Drawing.Point(492, 110);
            this.lb_NoiDung.Name = "lb_NoiDung";
            this.lb_NoiDung.Size = new System.Drawing.Size(76, 19);
            this.lb_NoiDung.TabIndex = 28;
            this.lb_NoiDung.Text = "Nội dung:";
            this.lb_NoiDung.Visible = false;
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = false;
            this.btn_Them.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Them.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Them.Depth = 0;
            this.btn_Them.HighEmphasis = true;
            this.btn_Them.Icon = null;
            this.btn_Them.Location = new System.Drawing.Point(184, 386);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Them.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(80, 35);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Them.UseAccentColor = false;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Visible = false;
            this.btn_Them.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btn_Gui
            // 
            this.btn_Gui.AutoSize = false;
            this.btn_Gui.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Gui.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Gui.Depth = 0;
            this.btn_Gui.HighEmphasis = true;
            this.btn_Gui.Icon = null;
            this.btn_Gui.Location = new System.Drawing.Point(496, 386);
            this.btn_Gui.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Gui.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.Size = new System.Drawing.Size(80, 35);
            this.btn_Gui.TabIndex = 29;
            this.btn_Gui.Text = "Gửi";
            this.btn_Gui.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Gui.UseAccentColor = false;
            this.btn_Gui.UseVisualStyleBackColor = true;
            this.btn_Gui.Visible = false;
            this.btn_Gui.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cb_HTML
            // 
            this.cb_HTML.AutoSize = true;
            this.cb_HTML.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_HTML.Location = new System.Drawing.Point(264, 276);
            this.cb_HTML.Name = "cb_HTML";
            this.cb_HTML.Size = new System.Drawing.Size(103, 23);
            this.cb_HTML.TabIndex = 30;
            this.cb_HTML.Text = "Html Body";
            this.cb_HTML.UseVisualStyleBackColor = true;
            this.cb_HTML.Visible = false;
            // 
            // lnb_Link
            // 
            this.lnb_Link.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnb_Link.Location = new System.Drawing.Point(732, 403);
            this.lnb_Link.Name = "lnb_Link";
            this.lnb_Link.Size = new System.Drawing.Size(27, 15);
            this.lnb_Link.TabIndex = 32;
            this.lnb_Link.TabStop = true;
            this.lnb_Link.Text = "đây";
            this.lnb_Link.Visible = false;
            this.lnb_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnb_FB_LinkClicked);
            // 
            // lb_HuongDan
            // 
            this.lb_HuongDan.AutoSize = true;
            this.lb_HuongDan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HuongDan.Location = new System.Drawing.Point(583, 388);
            this.lb_HuongDan.MaximumSize = new System.Drawing.Size(180, 200);
            this.lb_HuongDan.MinimumSize = new System.Drawing.Size(30, 0);
            this.lb_HuongDan.Name = "lb_HuongDan";
            this.lb_HuongDan.Size = new System.Drawing.Size(179, 30);
            this.lb_HuongDan.TabIndex = 31;
            this.lb_HuongDan.Text = "Nếu bạn gửi không thành công, vui lòng xem hướng dẫn tại";
            this.lb_HuongDan.Visible = false;
            // 
            // cb_HienThi
            // 
            this.cb_HienThi.AutoSize = true;
            this.cb_HienThi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_HienThi.Location = new System.Drawing.Point(184, 177);
            this.cb_HienThi.Name = "cb_HienThi";
            this.cb_HienThi.Size = new System.Drawing.Size(83, 23);
            this.cb_HienThi.TabIndex = 30;
            this.cb_HienThi.Text = "Hiển thị";
            this.cb_HienThi.UseVisualStyleBackColor = true;
            this.cb_HienThi.Visible = false;
            this.cb_HienThi.CheckedChanged += new System.EventHandler(this.cb_HienThi_CheckedChanged);
            // 
            // frm_PhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 465);
            this.Controls.Add(this.lnb_Link);
            this.Controls.Add(this.cb_HienThi);
            this.Controls.Add(this.cb_HTML);
            this.Controls.Add(this.btn_Gui);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lb_NoiDung);
            this.Controls.Add(this.tb_NoiDung);
            this.Controls.Add(this.lb_ChuDe);
            this.Controls.Add(this.lb_NguoiNhan);
            this.Controls.Add(this.cb_SSL);
            this.Controls.Add(this.tb_ChuDe);
            this.Controls.Add(this.txtRecipientEmail);
            this.Controls.Add(this.lb_TDK);
            this.Controls.Add(this.txtPortNumber);
            this.Controls.Add(this.lb_PH);
            this.Controls.Add(this.txtSmtpServer);
            this.Controls.Add(this.tb_MK);
            this.Controls.Add(this.lb_Port);
            this.Controls.Add(this.lb_SMTP);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_MatKhau);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lb_HuongDan);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_PhanHoi";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PhanHoi";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_PhanHoi_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_ChuDe;
        private System.Windows.Forms.TextBox tb_ChuDe;
        private System.Windows.Forms.Label lb_TDK;
        private System.Windows.Forms.Label lb_NguoiNhan;
        private System.Windows.Forms.TextBox txtRecipientEmail;
        private System.Windows.Forms.Label lb_PH;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar progressBar1;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_SMTP;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.TextBox tb_MK;
        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.CheckBox cb_SSL;
        private System.Windows.Forms.RichTextBox tb_NoiDung;
        private System.Windows.Forms.Label lb_NoiDung;
        private MaterialSkin.Controls.MaterialButton btn_Them;
        private MaterialSkin.Controls.MaterialButton btn_Gui;
        private System.Windows.Forms.CheckBox cb_HTML;
        private System.Windows.Forms.LinkLabel lnb_Link;
        private System.Windows.Forms.Label lb_HuongDan;
        private System.Windows.Forms.CheckBox cb_HienThi;
    }
}