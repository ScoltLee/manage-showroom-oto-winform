
namespace QLShowRoomOto_MaiLeDuan
{
    partial class frm_Oto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_TTOT = new System.Windows.Forms.Label();
            this.lb_MaXe = new System.Windows.Forms.Label();
            this.lb_TenXe = new System.Windows.Forms.Label();
            this.lb_NgayNhap = new System.Windows.Forms.Label();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.lb_NSX = new System.Windows.Forms.Label();
            this.tb_MaXe = new System.Windows.Forms.TextBox();
            this.tb_Ten = new System.Windows.Forms.TextBox();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new MaterialSkin.Controls.MaterialButton();
            this.btn_Sua = new MaterialSkin.Controls.MaterialButton();
            this.btn_Xoa = new MaterialSkin.Controls.MaterialButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_DanhSach = new System.Windows.Forms.Label();
            this.lb_NCC = new System.Windows.Forms.Label();
            this.btn_Dong = new MaterialSkin.Controls.MaterialButton();
            this.tb_NSX = new System.Windows.Forms.TextBox();
            this.lb_Anh = new System.Windows.Forms.Label();
            this.cb_NCC = new System.Windows.Forms.ComboBox();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new CircularProgressBar();
            this.btn_ThemAnh = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TTOT
            // 
            this.lb_TTOT.AutoSize = true;
            this.lb_TTOT.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TTOT.ForeColor = System.Drawing.Color.Red;
            this.lb_TTOT.Location = new System.Drawing.Point(332, 46);
            this.lb_TTOT.Name = "lb_TTOT";
            this.lb_TTOT.Size = new System.Drawing.Size(181, 24);
            this.lb_TTOT.TabIndex = 0;
            this.lb_TTOT.Text = "THÔNG TIN Ô TÔ";
            this.lb_TTOT.Visible = false;
            // 
            // lb_MaXe
            // 
            this.lb_MaXe.AutoSize = true;
            this.lb_MaXe.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaXe.Location = new System.Drawing.Point(108, 106);
            this.lb_MaXe.Name = "lb_MaXe";
            this.lb_MaXe.Size = new System.Drawing.Size(56, 19);
            this.lb_MaXe.TabIndex = 1;
            this.lb_MaXe.Text = "Mã xe:";
            this.lb_MaXe.Visible = false;
            // 
            // lb_TenXe
            // 
            this.lb_TenXe.AutoSize = true;
            this.lb_TenXe.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenXe.Location = new System.Drawing.Point(125, 141);
            this.lb_TenXe.Name = "lb_TenXe";
            this.lb_TenXe.Size = new System.Drawing.Size(39, 19);
            this.lb_TenXe.TabIndex = 1;
            this.lb_TenXe.Text = "Tên:";
            this.lb_TenXe.Visible = false;
            // 
            // lb_NgayNhap
            // 
            this.lb_NgayNhap.AutoSize = true;
            this.lb_NgayNhap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayNhap.Location = new System.Drawing.Point(80, 269);
            this.lb_NgayNhap.Name = "lb_NgayNhap";
            this.lb_NgayNhap.Size = new System.Drawing.Size(84, 19);
            this.lb_NgayNhap.TabIndex = 1;
            this.lb_NgayNhap.Text = "Ngày nhập:";
            this.lb_NgayNhap.Visible = false;
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuong.Location = new System.Drawing.Point(89, 304);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(75, 19);
            this.lb_SoLuong.TabIndex = 1;
            this.lb_SoLuong.Text = "Số lượng:";
            this.lb_SoLuong.Visible = false;
            // 
            // lb_NSX
            // 
            this.lb_NSX.AutoSize = true;
            this.lb_NSX.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NSX.Location = new System.Drawing.Point(117, 179);
            this.lb_NSX.Name = "lb_NSX";
            this.lb_NSX.Size = new System.Drawing.Size(47, 19);
            this.lb_NSX.TabIndex = 1;
            this.lb_NSX.Text = "NSX:";
            this.lb_NSX.Visible = false;
            // 
            // tb_MaXe
            // 
            this.tb_MaXe.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaXe.Location = new System.Drawing.Point(211, 103);
            this.tb_MaXe.Name = "tb_MaXe";
            this.tb_MaXe.Size = new System.Drawing.Size(188, 27);
            this.tb_MaXe.TabIndex = 2;
            this.tb_MaXe.Visible = false;
            // 
            // tb_Ten
            // 
            this.tb_Ten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ten.Location = new System.Drawing.Point(211, 138);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(188, 27);
            this.tb_Ten.TabIndex = 2;
            this.tb_Ten.Visible = false;
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoLuong.Location = new System.Drawing.Point(211, 301);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(188, 27);
            this.tb_SoLuong.TabIndex = 2;
            this.tb_SoLuong.Visible = false;
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe,
            this.Ten,
            this.NSX,
            this.NCC,
            this.NgayNhap,
            this.SoLuong});
            this.dgv_DanhSach.GridColor = System.Drawing.Color.White;
            this.dgv_DanhSach.Location = new System.Drawing.Point(59, 466);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSach.RowHeadersWidth = 45;
            this.dgv_DanhSach.Size = new System.Drawing.Size(664, 162);
            this.dgv_DanhSach.TabIndex = 6;
            this.dgv_DanhSach.Visible = false;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.HeaderText = "Mã xe";
            this.MaXe.Name = "MaXe";
            this.MaXe.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "NSX";
            this.NSX.Name = "NSX";
            this.NSX.ReadOnly = true;
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "NCC";
            this.NCC.HeaderText = "NCC";
            this.NCC.Name = "NCC";
            this.NCC.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // date_NgayNhap
            // 
            this.date_NgayNhap.CustomFormat = "dd/MM/yyyy";
            this.date_NgayNhap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgayNhap.Location = new System.Drawing.Point(211, 263);
            this.date_NgayNhap.Name = "date_NgayNhap";
            this.date_NgayNhap.Size = new System.Drawing.Size(188, 27);
            this.date_NgayNhap.TabIndex = 18;
            this.date_NgayNhap.Visible = false;
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = false;
            this.btn_Them.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Them.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Them.Depth = 0;
            this.btn_Them.HighEmphasis = true;
            this.btn_Them.Icon = null;
            this.btn_Them.Location = new System.Drawing.Point(158, 378);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Them.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(80, 35);
            this.btn_Them.TabIndex = 19;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Them.UseAccentColor = false;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Visible = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.AutoSize = false;
            this.btn_Sua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Sua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Sua.Depth = 0;
            this.btn_Sua.HighEmphasis = true;
            this.btn_Sua.Icon = null;
            this.btn_Sua.Location = new System.Drawing.Point(278, 378);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Sua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(80, 35);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Sua.UseAccentColor = false;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Visible = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSize = false;
            this.btn_Xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Xoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Xoa.Depth = 0;
            this.btn_Xoa.HighEmphasis = true;
            this.btn_Xoa.Icon = null;
            this.btn_Xoa.Location = new System.Drawing.Point(402, 378);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Xoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(80, 35);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Xoa.UseAccentColor = false;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Visible = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_DanhSach
            // 
            this.lb_DanhSach.AutoSize = true;
            this.lb_DanhSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DanhSach.Location = new System.Drawing.Point(55, 434);
            this.lb_DanhSach.Name = "lb_DanhSach";
            this.lb_DanhSach.Size = new System.Drawing.Size(109, 19);
            this.lb_DanhSach.TabIndex = 25;
            this.lb_DanhSach.Text = "Danh Sách Xe";
            this.lb_DanhSach.Visible = false;
            // 
            // lb_NCC
            // 
            this.lb_NCC.AutoSize = true;
            this.lb_NCC.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NCC.Location = new System.Drawing.Point(116, 224);
            this.lb_NCC.Name = "lb_NCC";
            this.lb_NCC.Size = new System.Drawing.Size(48, 19);
            this.lb_NCC.TabIndex = 1;
            this.lb_NCC.Text = "NCC:";
            this.lb_NCC.Visible = false;
            // 
            // btn_Dong
            // 
            this.btn_Dong.AutoSize = false;
            this.btn_Dong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Dong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Dong.Depth = 0;
            this.btn_Dong.HighEmphasis = true;
            this.btn_Dong.Icon = null;
            this.btn_Dong.Location = new System.Drawing.Point(527, 378);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Dong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(80, 35);
            this.btn_Dong.TabIndex = 19;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Dong.UseAccentColor = false;
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Visible = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // tb_NSX
            // 
            this.tb_NSX.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NSX.Location = new System.Drawing.Point(211, 176);
            this.tb_NSX.Name = "tb_NSX";
            this.tb_NSX.Size = new System.Drawing.Size(188, 27);
            this.tb_NSX.TabIndex = 2;
            this.tb_NSX.Visible = false;
            // 
            // lb_Anh
            // 
            this.lb_Anh.AutoSize = true;
            this.lb_Anh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Anh.Location = new System.Drawing.Point(462, 106);
            this.lb_Anh.Name = "lb_Anh";
            this.lb_Anh.Size = new System.Drawing.Size(41, 19);
            this.lb_Anh.TabIndex = 26;
            this.lb_Anh.Text = "Ảnh:";
            this.lb_Anh.Visible = false;
            // 
            // cb_NCC
            // 
            this.cb_NCC.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.cb_NCC.FormattingEnabled = true;
            this.cb_NCC.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không rõ"});
            this.cb_NCC.Location = new System.Drawing.Point(211, 221);
            this.cb_NCC.Name = "cb_NCC";
            this.cb_NCC.Size = new System.Drawing.Size(188, 27);
            this.cb_NCC.TabIndex = 48;
            this.cb_NCC.Visible = false;
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Image = global::QLShowRoomOto_MaiLeDuan.Properties.Resources.car_default;
            this.pb_Avatar.Location = new System.Drawing.Point(509, 106);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(192, 182);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Avatar.TabIndex = 5;
            this.pb_Avatar.TabStop = false;
            this.pb_Avatar.Visible = false;
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
            this.progressBar1.Location = new System.Drawing.Point(336, 272);
            this.progressBar1.Maximum = ((long)(100));
            this.progressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(130, 130);
            this.progressBar1.TabIndex = 24;
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
            this.btn_ThemAnh.Location = new System.Drawing.Point(563, 293);
            this.btn_ThemAnh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ThemAnh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ThemAnh.Name = "btn_ThemAnh";
            this.btn_ThemAnh.Size = new System.Drawing.Size(80, 35);
            this.btn_ThemAnh.TabIndex = 19;
            this.btn_ThemAnh.Text = "Thêm ảnh";
            this.btn_ThemAnh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ThemAnh.UseAccentColor = false;
            this.btn_ThemAnh.UseVisualStyleBackColor = true;
            this.btn_ThemAnh.Visible = false;
            this.btn_ThemAnh.Click += new System.EventHandler(this.btn_ThemAnh_Click);
            // 
            // frm_Oto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 649);
            this.Controls.Add(this.cb_NCC);
            this.Controls.Add(this.lb_Anh);
            this.Controls.Add(this.lb_DanhSach);
            this.Controls.Add(this.btn_ThemAnh);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.date_NgayNhap);
            this.Controls.Add(this.dgv_DanhSach);
            this.Controls.Add(this.tb_SoLuong);
            this.Controls.Add(this.tb_NSX);
            this.Controls.Add(this.tb_Ten);
            this.Controls.Add(this.lb_NCC);
            this.Controls.Add(this.tb_MaXe);
            this.Controls.Add(this.lb_NSX);
            this.Controls.Add(this.lb_SoLuong);
            this.Controls.Add(this.lb_NgayNhap);
            this.Controls.Add(this.lb_TenXe);
            this.Controls.Add(this.lb_MaXe);
            this.Controls.Add(this.lb_TTOT);
            this.Controls.Add(this.pb_Avatar);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_Oto";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Danh Sách Sinh Viên";
            this.Load += new System.EventHandler(this.frm_Oto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TTOT;
        private System.Windows.Forms.Label lb_MaXe;
        private System.Windows.Forms.Label lb_TenXe;
        private System.Windows.Forms.Label lb_NgayNhap;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Label lb_NSX;
        private System.Windows.Forms.TextBox tb_MaXe;
        private System.Windows.Forms.TextBox tb_Ten;
        private System.Windows.Forms.TextBox tb_SoLuong;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.DateTimePicker date_NgayNhap;
        private MaterialSkin.Controls.MaterialButton btn_Them;
        private MaterialSkin.Controls.MaterialButton btn_Sua;
        private MaterialSkin.Controls.MaterialButton btn_Xoa;
        private CircularProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.Label lb_DanhSach;
        private System.Windows.Forms.Label lb_NCC;
        private MaterialSkin.Controls.MaterialButton btn_Dong;
        private System.Windows.Forms.TextBox tb_NSX;
        private System.Windows.Forms.Label lb_Anh;
        private System.Windows.Forms.ComboBox cb_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private MaterialSkin.Controls.MaterialButton btn_ThemAnh;
    }
}