
namespace QLShowRoomOto_MaiLeDuan
{
    partial class frm_DangNhap
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
            this.lb_Check = new System.Windows.Forms.Label();
            this.tb_MK = new System.Windows.Forms.TextBox();
            this.tb_TK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new MaterialSkin.Controls.MaterialButton();
            this.btn_NhapLai = new MaterialSkin.Controls.MaterialButton();
            this.btn_DangNhap = new MaterialSkin.Controls.MaterialButton();
            this.tm_Start = new System.Windows.Forms.Timer(this.components);
            this.cb_HienThi = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // lb_Check
            // 
            this.lb_Check.AutoSize = true;
            this.lb_Check.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Check.ForeColor = System.Drawing.Color.Red;
            this.lb_Check.Location = new System.Drawing.Point(328, 223);
            this.lb_Check.Name = "lb_Check";
            this.lb_Check.Size = new System.Drawing.Size(0, 19);
            this.lb_Check.TabIndex = 17;
            // 
            // tb_MK
            // 
            this.tb_MK.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MK.Location = new System.Drawing.Point(328, 177);
            this.tb_MK.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.tb_MK.Name = "tb_MK";
            this.tb_MK.Size = new System.Drawing.Size(247, 32);
            this.tb_MK.TabIndex = 15;
            this.tb_MK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_MK.UseSystemPasswordChar = true;
            // 
            // tb_TK
            // 
            this.tb_TK.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TK.Location = new System.Drawing.Point(328, 126);
            this.tb_TK.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.tb_TK.Name = "tb_TK";
            this.tb_TK.Size = new System.Drawing.Size(247, 32);
            this.tb_TK.TabIndex = 16;
            this.tb_TK.Text = "admin";
            this.tb_TK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(150, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(103, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Tài Khoản:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AutoSize = false;
            this.btn_Thoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Thoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Thoat.Depth = 0;
            this.btn_Thoat.HighEmphasis = true;
            this.btn_Thoat.Icon = null;
            this.btn_Thoat.Location = new System.Drawing.Point(524, 261);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Thoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(104, 35);
            this.btn_Thoat.TabIndex = 20;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Thoat.UseAccentColor = false;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.AutoSize = false;
            this.btn_NhapLai.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_NhapLai.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_NhapLai.Depth = 0;
            this.btn_NhapLai.HighEmphasis = true;
            this.btn_NhapLai.Icon = null;
            this.btn_NhapLai.Location = new System.Drawing.Point(368, 261);
            this.btn_NhapLai.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_NhapLai.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(104, 35);
            this.btn_NhapLai.TabIndex = 21;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_NhapLai.UseAccentColor = false;
            this.btn_NhapLai.UseVisualStyleBackColor = true;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.AutoSize = false;
            this.btn_DangNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DangNhap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_DangNhap.Depth = 0;
            this.btn_DangNhap.HighEmphasis = true;
            this.btn_DangNhap.Icon = null;
            this.btn_DangNhap.Location = new System.Drawing.Point(214, 261);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_DangNhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(104, 35);
            this.btn_DangNhap.TabIndex = 22;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_DangNhap.UseAccentColor = false;
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // tm_Start
            // 
            this.tm_Start.Enabled = true;
            this.tm_Start.Interval = 40;
            this.tm_Start.Tick += new System.EventHandler(this.tm_Start_Tick);
            // 
            // cb_HienThi
            // 
            this.cb_HienThi.AutoSize = true;
            this.cb_HienThi.Depth = 0;
            this.cb_HienThi.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_HienThi.Location = new System.Drawing.Point(584, 174);
            this.cb_HienThi.Margin = new System.Windows.Forms.Padding(0);
            this.cb_HienThi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cb_HienThi.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_HienThi.Name = "cb_HienThi";
            this.cb_HienThi.Ripple = true;
            this.cb_HienThi.Size = new System.Drawing.Size(89, 37);
            this.cb_HienThi.TabIndex = 23;
            this.cb_HienThi.Text = "Hiển thị";
            this.cb_HienThi.UseVisualStyleBackColor = true;
            this.cb_HienThi.CheckedChanged += new System.EventHandler(this.cb_HienThi_CheckedChanged);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 360);
            this.Controls.Add(this.cb_HienThi);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_NhapLai);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.lb_Check);
            this.Controls.Add(this.tb_MK);
            this.Controls.Add(this.tb_TK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhap";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Check;
        private System.Windows.Forms.TextBox tb_MK;
        private System.Windows.Forms.TextBox tb_TK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btn_Thoat;
        private MaterialSkin.Controls.MaterialButton btn_NhapLai;
        private MaterialSkin.Controls.MaterialButton btn_DangNhap;
        private System.Windows.Forms.Timer tm_Start;
        private MaterialSkin.Controls.MaterialCheckbox cb_HienThi;
    }
}