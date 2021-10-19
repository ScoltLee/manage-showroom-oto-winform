
namespace QLShowRoomOto_MaiLeDuan
{
    partial class frm_KhachHang
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
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.tb_MaKH = new System.Windows.Forms.TextBox();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.lb_TTKH = new System.Windows.Forms.Label();
            this.lb_Anh = new System.Windows.Forms.Label();
            this.btn_Xoa = new MaterialSkin.Controls.MaterialButton();
            this.btn_Sua = new MaterialSkin.Controls.MaterialButton();
            this.btn_Them = new MaterialSkin.Controls.MaterialButton();
            this.btn_Dong = new MaterialSkin.Controls.MaterialButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lb_DanhSach = new System.Windows.Forms.Label();
            this.progressBar1 = new CircularProgressBar();
            this.btn_ThemAnh = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Image = global::QLShowRoomOto_MaiLeDuan.Properties.Resources.user_default;
            this.pb_Avatar.Location = new System.Drawing.Point(518, 106);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(157, 182);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Avatar.TabIndex = 33;
            this.pb_Avatar.TabStop = false;
            this.pb_Avatar.Visible = false;
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi});
            this.dgv_DanhSach.Location = new System.Drawing.Point(57, 463);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.ReadOnly = true;
            this.dgv_DanhSach.Size = new System.Drawing.Size(653, 162);
            this.dgv_DanhSach.TabIndex = 34;
            this.dgv_DanhSach.Visible = false;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HoTen.Location = new System.Drawing.Point(217, 149);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(188, 27);
            this.tb_HoTen.TabIndex = 27;
            this.tb_HoTen.Visible = false;
            // 
            // tb_MaKH
            // 
            this.tb_MaKH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaKH.Location = new System.Drawing.Point(217, 106);
            this.tb_MaKH.Name = "tb_MaKH";
            this.tb_MaKH.Size = new System.Drawing.Size(188, 27);
            this.tb_MaKH.TabIndex = 26;
            this.tb_MaKH.Visible = false;
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GioiTinh.Location = new System.Drawing.Point(86, 196);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(75, 19);
            this.lb_GioiTinh.TabIndex = 24;
            this.lb_GioiTinh.Text = "Giới tính:";
            this.lb_GioiTinh.Visible = false;
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgaySinh.Location = new System.Drawing.Point(80, 242);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(81, 19);
            this.lb_NgaySinh.TabIndex = 21;
            this.lb_NgaySinh.Text = "Ngày sinh:";
            this.lb_NgaySinh.Visible = false;
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.Location = new System.Drawing.Point(83, 152);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(78, 19);
            this.lb_HoTen.TabIndex = 20;
            this.lb_HoTen.Text = "Họ và tên:";
            this.lb_HoTen.Visible = false;
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaKH.Location = new System.Drawing.Point(47, 109);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(114, 19);
            this.lb_MaKH.TabIndex = 25;
            this.lb_MaKH.Text = "Mã khách hàng:";
            this.lb_MaKH.Visible = false;
            // 
            // lb_TTKH
            // 
            this.lb_TTKH.AutoSize = true;
            this.lb_TTKH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TTKH.ForeColor = System.Drawing.Color.Red;
            this.lb_TTKH.Location = new System.Drawing.Point(283, 46);
            this.lb_TTKH.Name = "lb_TTKH";
            this.lb_TTKH.Size = new System.Drawing.Size(277, 24);
            this.lb_TTKH.TabIndex = 19;
            this.lb_TTKH.Text = "THÔNG TIN KHÁCH HÀNG";
            this.lb_TTKH.Visible = false;
            // 
            // lb_Anh
            // 
            this.lb_Anh.AutoSize = true;
            this.lb_Anh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Anh.Location = new System.Drawing.Point(460, 109);
            this.lb_Anh.Name = "lb_Anh";
            this.lb_Anh.Size = new System.Drawing.Size(41, 19);
            this.lb_Anh.TabIndex = 22;
            this.lb_Anh.Text = "Ảnh:";
            this.lb_Anh.Visible = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSize = false;
            this.btn_Xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Xoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Xoa.Depth = 0;
            this.btn_Xoa.HighEmphasis = true;
            this.btn_Xoa.Icon = null;
            this.btn_Xoa.Location = new System.Drawing.Point(409, 364);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Xoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(80, 35);
            this.btn_Xoa.TabIndex = 36;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Xoa.UseAccentColor = false;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Visible = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.AutoSize = false;
            this.btn_Sua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Sua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Sua.Depth = 0;
            this.btn_Sua.HighEmphasis = true;
            this.btn_Sua.Icon = null;
            this.btn_Sua.Location = new System.Drawing.Point(285, 364);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Sua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(80, 35);
            this.btn_Sua.TabIndex = 37;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Sua.UseAccentColor = false;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Visible = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = false;
            this.btn_Them.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Them.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Them.Depth = 0;
            this.btn_Them.HighEmphasis = true;
            this.btn_Them.Icon = null;
            this.btn_Them.Location = new System.Drawing.Point(165, 364);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Them.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(80, 35);
            this.btn_Them.TabIndex = 38;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Them.UseAccentColor = false;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Visible = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.AutoSize = false;
            this.btn_Dong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Dong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Dong.Depth = 0;
            this.btn_Dong.HighEmphasis = true;
            this.btn_Dong.Icon = null;
            this.btn_Dong.Location = new System.Drawing.Point(534, 364);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Dong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(80, 35);
            this.btn_Dong.TabIndex = 36;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Dong.UseAccentColor = false;
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Visible = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(98, 281);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(63, 19);
            this.lb_DiaChi.TabIndex = 21;
            this.lb_DiaChi.Text = "Địa chỉ:";
            this.lb_DiaChi.Visible = false;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DiaChi.Location = new System.Drawing.Point(217, 278);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(188, 27);
            this.tb_DiaChi.TabIndex = 28;
            this.tb_DiaChi.Visible = false;
            // 
            // cb_GioiTinh
            // 
            this.cb_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.cb_GioiTinh.FormattingEnabled = true;
            this.cb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không rõ"});
            this.cb_GioiTinh.Location = new System.Drawing.Point(217, 193);
            this.cb_GioiTinh.Name = "cb_GioiTinh";
            this.cb_GioiTinh.Size = new System.Drawing.Size(188, 27);
            this.cb_GioiTinh.TabIndex = 47;
            this.cb_GioiTinh.Visible = false;
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.date_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySinh.Location = new System.Drawing.Point(217, 236);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(188, 27);
            this.date_NgaySinh.TabIndex = 48;
            this.date_NgaySinh.Visible = false;
            // 
            // lb_DanhSach
            // 
            this.lb_DanhSach.AutoSize = true;
            this.lb_DanhSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DanhSach.Location = new System.Drawing.Point(56, 427);
            this.lb_DanhSach.Name = "lb_DanhSach";
            this.lb_DanhSach.Size = new System.Drawing.Size(178, 19);
            this.lb_DanhSach.TabIndex = 49;
            this.lb_DanhSach.Text = "Danh Sách Khách Hàng";
            this.lb_DanhSach.Visible = false;
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
            this.progressBar1.Location = new System.Drawing.Point(337, 278);
            this.progressBar1.Maximum = ((long)(100));
            this.progressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(130, 130);
            this.progressBar1.TabIndex = 46;
            this.progressBar1.Text = "0";
            this.progressBar1.Value = ((long)(0));
            // 
            // btn_ThemAnh
            // 
            this.btn_ThemAnh.AutoSize = false;
            this.btn_ThemAnh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ThemAnh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ThemAnh.Depth = 0;
            this.btn_ThemAnh.HighEmphasis = true;
            this.btn_ThemAnh.Icon = null;
            this.btn_ThemAnh.Location = new System.Drawing.Point(555, 297);
            this.btn_ThemAnh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ThemAnh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ThemAnh.Name = "btn_ThemAnh";
            this.btn_ThemAnh.Size = new System.Drawing.Size(80, 35);
            this.btn_ThemAnh.TabIndex = 50;
            this.btn_ThemAnh.Text = "Thêm ảnh";
            this.btn_ThemAnh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ThemAnh.UseAccentColor = false;
            this.btn_ThemAnh.UseVisualStyleBackColor = true;
            this.btn_ThemAnh.Visible = false;
            this.btn_ThemAnh.Click += new System.EventHandler(this.btn_ThemAnh_Click);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 649);
            this.Controls.Add(this.btn_ThemAnh);
            this.Controls.Add(this.lb_DanhSach);
            this.Controls.Add(this.date_NgaySinh);
            this.Controls.Add(this.cb_GioiTinh);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DanhSach);
            this.Controls.Add(this.pb_Avatar);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_HoTen);
            this.Controls.Add(this.tb_MaKH);
            this.Controls.Add(this.lb_GioiTinh);
            this.Controls.Add(this.lb_DiaChi);
            this.Controls.Add(this.lb_Anh);
            this.Controls.Add(this.lb_NgaySinh);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.lb_MaKH);
            this.Controls.Add(this.lb_TTKH);
            this.Controls.Add(this.progressBar1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_KhachHang";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.TextBox tb_MaKH;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.Label lb_TTKH;
        private System.Windows.Forms.Label lb_Anh;
        private MaterialSkin.Controls.MaterialButton btn_Xoa;
        private MaterialSkin.Controls.MaterialButton btn_Sua;
        private MaterialSkin.Controls.MaterialButton btn_Them;
        private MaterialSkin.Controls.MaterialButton btn_Dong;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar progressBar1;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.ComboBox cb_GioiTinh;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.Label lb_DanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private MaterialSkin.Controls.MaterialButton btn_ThemAnh;
    }
}