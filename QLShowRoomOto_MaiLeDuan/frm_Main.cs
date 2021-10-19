using MaterialSkin.Controls;
using QLShowRoomOto_MaiLeDuan;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLShowRoomOto_MaiLeDuan
{
    public partial class frm_Main : MaterialForm
    {
        LOPDUNGCHUNG chung;
        public frm_Main()
        {
            frm_DangNhap obj = (frm_DangNhap)Application.OpenForms["frm_DangNhap"];
            obj.Close();
            chung = new LOPDUNGCHUNG();
            InitializeComponent();
            chung.GiaoDien(this);
        }

        private void danhSáchOtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Oto"] == null)
            {
                frm_Oto sinhvien = new frm_Oto();
                sinhvien.MdiParent = this;
                sinhvien.Show();
            }
            else
            {
                Application.OpenForms["frm_Oto"].Activate();
            }
            Application.OpenForms["frm_Oto"].Location = new Point(0, 0);
        }

        private void tm_Timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void tm_Start_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                tm_Start.Stop();
            }
            Opacity += .2;
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void hồSơKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_KhachHang"] == null)
            {
                frm_KhachHang khachhang = new frm_KhachHang();
                khachhang.MdiParent = this;
                khachhang.Show();
            }
            else
            {
                Application.OpenForms["frm_KhachHang"].Activate();
            }
            Application.OpenForms["frm_KhachHang"].Location = new Point(250, 0);
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            DialogResult dt = chung.ThongBao("Cảnh Báo", "Bạn thật sự muốn thoát?", System.Drawing.SystemIcons.Question, dialogResult);
            if (dt == DialogResult.OK)
                Close();
        }

        private void Sbtn_Exit_Click(object sender, EventArgs e)
        {
            đóngToolStripMenuItem_Click(sender, e);
        }

        private void Sbtn_Car_Click(object sender, EventArgs e)
        {
            danhSáchOtoToolStripMenuItem_Click(sender, e);
        }

        private void Sbtn_KhachHang_Click(object sender, EventArgs e)
        {
            hồSơKháchHàngToolStripMenuItem_Click(sender, e);
        }

        private void hồSơNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhaCungCap"] == null)
            {
                frm_NhaCungCap ncc = new frm_NhaCungCap();
                ncc.MdiParent = this;
                ncc.Show();
            }
            else
            {
                Application.OpenForms["frm_NhaCungCap"].Activate();
            }
            Application.OpenForms["frm_NhaCungCap"].Location = new Point(450, 0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            hồSơNhàCungCấpToolStripMenuItem_Click(sender, e);
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GioiThieu gioiThieu = new frm_GioiThieu();
            chung.Popup(gioiThieu, this.Location);
        }

        private void Tbtn_GioiThieu_Click(object sender, EventArgs e)
        {
            giớiThiệuToolStripMenuItem_Click(sender, e);
        }

        private void phảnHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PhanHoi phanHoi = new frm_PhanHoi();
            chung.Popup(phanHoi, this.Location);
        }

        private void Sbtn_GiupDo_Click(object sender, EventArgs e)
        {
            phảnHồiToolStripMenuItem_Click(sender, e);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            DialogResult dt = chung.ThongBao("Cảnh Báo", "Bạn thật sự muốn đăng xuất?", System.Drawing.SystemIcons.Warning, dialogResult);
            if (dt == DialogResult.OK)
            {
                frm_DangNhap dangNhap = new frm_DangNhap();
                dangNhap.Show();
                this.Hide();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            đăngXuấtToolStripMenuItem_Click(sender, e);
        }
    }
}
