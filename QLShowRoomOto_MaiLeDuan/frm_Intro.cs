using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace QLShowRoomOto_MaiLeDuan
{
    public partial class frm_Intro : DevExpress.XtraEditors.XtraForm
    {
        public frm_Intro()
        {
            FluentSplashScreenOptions op = new FluentSplashScreenOptions();
            op.Title = "When Only The Best Will Do";
            op.Subtitle = "Developed by Le Duan";
            op.RightFooter = "Starting...";
            op.LeftFooter = "Copyright © 2021 - 2022 CS 414 A" + Environment.NewLine + "All Rights reserved.";
            op.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            op.OpacityColor = Color.FromArgb(16, 110, 190);
            op.Opacity = 130;
            op.AppearanceLeftFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            SplashScreenManager.ShowFluentSplashScreen(op, parentForm: this, useFadeIn: true, useFadeOut: true);
            InitializeComponent();
            Thread.Sleep(2000);
            SplashScreenManager.CloseForm(false, 200, this);
            frm_DangNhap dangNhap = new frm_DangNhap();
            Thread.Sleep(800);
            dangNhap.Show();
            dangNhap.Activate();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}