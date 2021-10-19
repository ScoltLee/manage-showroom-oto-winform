
using System.Drawing;

namespace QLShowRoomOto_MaiLeDuan
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýOtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchOtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tm_Timer = new System.Windows.Forms.Timer(this.components);
            this.tm_Start = new System.Windows.Forms.Timer(this.components);
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sbtn_Exit = new System.Windows.Forms.ToolStripButton();
            this.Sbtn_Car = new System.Windows.Forms.ToolStripButton();
            this.Sbtn_KhachHang = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Tbtn_GioiThieu = new System.Windows.Forms.ToolStripButton();
            this.Sbtn_GiupDo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýOtoToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem,
            this.giúpĐỡToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đóngToolStripMenuItem
            // 
            this.đóngToolStripMenuItem.Name = "đóngToolStripMenuItem";
            this.đóngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.đóngToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.đóngToolStripMenuItem.Text = "Đóng";
            this.đóngToolStripMenuItem.Click += new System.EventHandler(this.đóngToolStripMenuItem_Click);
            // 
            // quảnLýOtoToolStripMenuItem
            // 
            this.quảnLýOtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchOtoToolStripMenuItem});
            this.quảnLýOtoToolStripMenuItem.Name = "quảnLýOtoToolStripMenuItem";
            this.quảnLýOtoToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.quảnLýOtoToolStripMenuItem.Text = "Quản Lý Ôtô";
            // 
            // danhSáchOtoToolStripMenuItem
            // 
            this.danhSáchOtoToolStripMenuItem.Name = "danhSáchOtoToolStripMenuItem";
            this.danhSáchOtoToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.danhSáchOtoToolStripMenuItem.Text = "Danh sách Ôtô";
            this.danhSáchOtoToolStripMenuItem.Click += new System.EventHandler(this.danhSáchOtoToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơKháchHàngToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(161, 23);
            this.kháchHàngToolStripMenuItem.Text = "Thông Tin Khách Hàng";
            // 
            // hồSơKháchHàngToolStripMenuItem
            // 
            this.hồSơKháchHàngToolStripMenuItem.Name = "hồSơKháchHàngToolStripMenuItem";
            this.hồSơKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.hồSơKháchHàngToolStripMenuItem.Text = "Hồ Sơ Khách Hàng";
            this.hồSơKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.hồSơKháchHàngToolStripMenuItem_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơNhàCungCấpToolStripMenuItem});
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            // 
            // hồSơNhàCungCấpToolStripMenuItem
            // 
            this.hồSơNhàCungCấpToolStripMenuItem.Name = "hồSơNhàCungCấpToolStripMenuItem";
            this.hồSơNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.hồSơNhàCungCấpToolStripMenuItem.Text = "Hồ Sơ Nhà Cung Cấp";
            this.hồSơNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.hồSơNhàCungCấpToolStripMenuItem_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.giớiThiệuToolStripMenuItem.Text = "Giới Thiệu";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.giúpĐỡToolStripMenuItem.Text = "Phản Hồi";
            this.giúpĐỡToolStripMenuItem.Click += new System.EventHandler(this.phảnHồiToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sbtn_Exit,
            this.toolStripSeparator1,
            this.Sbtn_Car,
            this.Sbtn_KhachHang,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.Tbtn_GioiThieu,
            this.Sbtn_GiupDo,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 91);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 32);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // tm_Timer
            // 
            this.tm_Timer.Enabled = true;
            this.tm_Timer.Interval = 1000;
            this.tm_Timer.Tick += new System.EventHandler(this.tm_Timer_Tick);
            // 
            // tm_Start
            // 
            this.tm_Start.Enabled = true;
            this.tm_Start.Interval = 40;
            this.tm_Start.Tick += new System.EventHandler(this.tm_Start_Tick);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // Sbtn_Exit
            // 
            this.Sbtn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sbtn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Sbtn_Exit.Image")));
            this.Sbtn_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Sbtn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sbtn_Exit.Name = "Sbtn_Exit";
            this.Sbtn_Exit.Size = new System.Drawing.Size(29, 29);
            this.Sbtn_Exit.ToolTipText = "Exit";
            this.Sbtn_Exit.Click += new System.EventHandler(this.Sbtn_Exit_Click);
            // 
            // Sbtn_Car
            // 
            this.Sbtn_Car.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sbtn_Car.Image = ((System.Drawing.Image)(resources.GetObject("Sbtn_Car.Image")));
            this.Sbtn_Car.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Sbtn_Car.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sbtn_Car.Name = "Sbtn_Car";
            this.Sbtn_Car.Size = new System.Drawing.Size(29, 29);
            this.Sbtn_Car.Text = "Danh sách ôtô";
            this.Sbtn_Car.Click += new System.EventHandler(this.Sbtn_Car_Click);
            // 
            // Sbtn_KhachHang
            // 
            this.Sbtn_KhachHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sbtn_KhachHang.Image = global::QLShowRoomOto_MaiLeDuan.Properties.Resources.user;
            this.Sbtn_KhachHang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Sbtn_KhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sbtn_KhachHang.Name = "Sbtn_KhachHang";
            this.Sbtn_KhachHang.Size = new System.Drawing.Size(29, 29);
            this.Sbtn_KhachHang.Text = "Hồ sơ khách hàng";
            this.Sbtn_KhachHang.Click += new System.EventHandler(this.Sbtn_KhachHang_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::QLShowRoomOto_MaiLeDuan.Properties.Resources.supplier;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton1.Text = "Hồ sơ NCC";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Tbtn_GioiThieu
            // 
            this.Tbtn_GioiThieu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tbtn_GioiThieu.Image = global::QLShowRoomOto_MaiLeDuan.Properties.Resources.introduction;
            this.Tbtn_GioiThieu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tbtn_GioiThieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbtn_GioiThieu.Name = "Tbtn_GioiThieu";
            this.Tbtn_GioiThieu.Size = new System.Drawing.Size(29, 29);
            this.Tbtn_GioiThieu.Text = "Giới thiệu";
            this.Tbtn_GioiThieu.Click += new System.EventHandler(this.Tbtn_GioiThieu_Click);
            // 
            // Sbtn_GiupDo
            // 
            this.Sbtn_GiupDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sbtn_GiupDo.Image = global::QLShowRoomOto_MaiLeDuan.Properties.Resources.support;
            this.Sbtn_GiupDo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Sbtn_GiupDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sbtn_GiupDo.Name = "Sbtn_GiupDo";
            this.Sbtn_GiupDo.Size = new System.Drawing.Size(29, 29);
            this.Sbtn_GiupDo.Text = "Phản hồi";
            this.Sbtn_GiupDo.Click += new System.EventHandler(this.Sbtn_GiupDo_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::QLShowRoomOto_MaiLeDuan.Properties.Resources.logout;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton2.Text = "Đăng xuất";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frm_Main";
            this.Opacity = 0D;
            this.Text = "Quản Lý Show Room Ôtô";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýOtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Sbtn_Exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton Sbtn_Car;
        private System.Windows.Forms.ToolStripButton Sbtn_KhachHang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer tm_Timer;
        private System.Windows.Forms.ToolStripMenuItem danhSáchOtoToolStripMenuItem;
        private System.Windows.Forms.Timer tm_Start;
        private System.Windows.Forms.ToolStripMenuItem hồSơKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Tbtn_GioiThieu;
        private System.Windows.Forms.ToolStripButton Sbtn_GiupDo;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem hồSơNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

