using MaterialSkin.Controls;
using QLShowRoomOto_MaiLeDuan;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLShowRoomOto_MaiLeDuan
{
    public partial class frm_DangNhap : MaterialForm
    {
        int dem = 0;
        LOPDUNGCHUNG chung;
        public frm_DangNhap()
        {           
            chung = new LOPDUNGCHUNG();
            InitializeComponent();
            chung.GiaoDien(this);
            this.ActiveControl = tb_MK;
        }      
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            btn_DangNhap.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (kiemTraTK())
            {
                int result = (int)chung.TraVeGT("SELECT COUNT([MatKhau]) FROM TAIKHOAN WHERE [MatKhau] = '" + tb_MK.Text + "' AND [TaiKhoan] = '" + tb_TK.Text + "'");
                if (result >= 1)
                {
                    frm_Main main = new frm_Main();
                    main.Show();
                }
                else
                {
                    dem++;
                    lb_Check.Text = "Mật khẩu không chính xác, bạn còn " + (3 - dem) + " lần thử.";
                    if (dem == 3)
                    {
                        var dialogResult = new DialogResult[] { DialogResult.OK };
                        DialogResult dt = chung.ThongBao("Cảnh Báo", "Bạn đã nhập sai 3 lần, ứng dụng sẽ được thoát.", SystemIcons.Question, dialogResult);
                        if (dt == DialogResult.OK)
                            Application.Exit();
                    }
                }
            }
            else
                lb_Check.Text = "Tài khoản không tồn tại";
            btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            tb_TK.Text = "";
            tb_MK.Text = "";
            lb_Check.Text = "";
            this.ActiveControl = tb_TK;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            var dialogResult = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            DialogResult dt = chung.ThongBao("Cảnh Báo", "Bạn thật sự muốn thoát?", System.Drawing.SystemIcons.Question, dialogResult);
            if (dt == DialogResult.OK)
                Application.Exit();
        }

        private bool kiemTraTK()
        {
            int result = (int)chung.TraVeGT("SELECT COUNT([TaiKhoan]) FROM TAIKHOAN WHERE [TaiKhoan] = '" + tb_TK.Text + "'");
            if (result >= 1)
                return true;
            else
                return false;
        }

        private void tm_Start_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                tm_Start.Stop();
            }
            Opacity += .2;
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
