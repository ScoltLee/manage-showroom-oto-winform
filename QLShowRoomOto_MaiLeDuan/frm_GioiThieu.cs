using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLShowRoomOto_MaiLeDuan;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace QLShowRoomOto_MaiLeDuan
{
    public partial class frm_GioiThieu : MaterialForm
    {
        public frm_GioiThieu()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void lb_FB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/scotllee");
            this.TopMost = false;
        }

        private void lb_GH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ScoltLee/");
            this.TopMost = false;
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
            this.lb_TTUD.Visible = true;
            this.lb_TenUngDung.Visible = true;
            this.lb_PhatTrien.Visible = true;
            this.lb_LienHe.Visible = true;
            this.lb_Email.Visible = true;
            this.lb_FB.Visible = true;
            this.lb_Code.Visible = true;
            this.lb_ThuVien.Visible = true;
            this.cpb_Avatar.Visible = true;
            this.lnb_GH.Visible = true;
            this.lnb_FB.Visible = true;          
            this.progressBar1.Visible = false;
        }
        private void frm_GioiThieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["frm_Main"].Activate();
        }
    }
}
