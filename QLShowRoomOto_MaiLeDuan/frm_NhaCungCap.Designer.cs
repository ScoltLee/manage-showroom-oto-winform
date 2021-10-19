
namespace QLShowRoomOto_MaiLeDuan
{
    partial class frm_NhaCungCap
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
            this.lb_DanhSach = new System.Windows.Forms.Label();
            this.btn_Dong = new MaterialSkin.Controls.MaterialButton();
            this.btn_Xoa = new MaterialSkin.Controls.MaterialButton();
            this.btn_Sua = new MaterialSkin.Controls.MaterialButton();
            this.btn_Them = new MaterialSkin.Controls.MaterialButton();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_TenNCC = new System.Windows.Forms.TextBox();
            this.tb_MaNCC = new System.Windows.Forms.TextBox();
            this.lb_GhiChu = new System.Windows.Forms.Label();
            this.lb_TenNCC = new System.Windows.Forms.Label();
            this.lb_MaNCC = new System.Windows.Forms.Label();
            this.lb_NCC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new CircularProgressBar();
            this.lb_Anh = new System.Windows.Forms.Label();
            this.btn_ThemAnh = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DanhSach
            // 
            this.lb_DanhSach.AutoSize = true;
            this.lb_DanhSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DanhSach.Location = new System.Drawing.Point(72, 422);
            this.lb_DanhSach.Name = "lb_DanhSach";
            this.lb_DanhSach.Size = new System.Drawing.Size(125, 19);
            this.lb_DanhSach.TabIndex = 46;
            this.lb_DanhSach.Text = "Danh Sách NCC";
            this.lb_DanhSach.Visible = false;
            // 
            // btn_Dong
            // 
            this.btn_Dong.AutoSize = false;
            this.btn_Dong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Dong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Dong.Depth = 0;
            this.btn_Dong.HighEmphasis = true;
            this.btn_Dong.Icon = null;
            this.btn_Dong.Location = new System.Drawing.Point(541, 364);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Dong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(80, 35);
            this.btn_Dong.TabIndex = 44;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Dong.UseAccentColor = false;
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Visible = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSize = false;
            this.btn_Xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Xoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Xoa.Depth = 0;
            this.btn_Xoa.HighEmphasis = true;
            this.btn_Xoa.Icon = null;
            this.btn_Xoa.Location = new System.Drawing.Point(413, 364);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Xoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(80, 35);
            this.btn_Xoa.TabIndex = 43;
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
            this.btn_Sua.Location = new System.Drawing.Point(286, 364);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Sua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(80, 35);
            this.btn_Sua.TabIndex = 42;
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
            this.btn_Them.TabIndex = 41;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Them.UseAccentColor = false;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Visible = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi});
            this.dgv_DanhSach.GridColor = System.Drawing.Color.White;
            this.dgv_DanhSach.Location = new System.Drawing.Point(76, 458);
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
            this.dgv_DanhSach.Size = new System.Drawing.Size(653, 162);
            this.dgv_DanhSach.TabIndex = 39;
            this.dgv_DanhSach.Visible = false;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DiaChi.Location = new System.Drawing.Point(207, 174);
            this.tb_DiaChi.Multiline = true;
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(219, 126);
            this.tb_DiaChi.TabIndex = 35;
            this.tb_DiaChi.Visible = false;
            // 
            // tb_TenNCC
            // 
            this.tb_TenNCC.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenNCC.Location = new System.Drawing.Point(207, 136);
            this.tb_TenNCC.Name = "tb_TenNCC";
            this.tb_TenNCC.Size = new System.Drawing.Size(219, 27);
            this.tb_TenNCC.TabIndex = 33;
            this.tb_TenNCC.Visible = false;
            // 
            // tb_MaNCC
            // 
            this.tb_MaNCC.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaNCC.Location = new System.Drawing.Point(207, 101);
            this.tb_MaNCC.Name = "tb_MaNCC";
            this.tb_MaNCC.Size = new System.Drawing.Size(219, 27);
            this.tb_MaNCC.TabIndex = 37;
            this.tb_MaNCC.Visible = false;
            // 
            // lb_GhiChu
            // 
            this.lb_GhiChu.AutoSize = true;
            this.lb_GhiChu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GhiChu.Location = new System.Drawing.Point(92, 177);
            this.lb_GhiChu.Name = "lb_GhiChu";
            this.lb_GhiChu.Size = new System.Drawing.Size(63, 19);
            this.lb_GhiChu.TabIndex = 31;
            this.lb_GhiChu.Text = "Địa chỉ:";
            this.lb_GhiChu.Visible = false;
            // 
            // lb_TenNCC
            // 
            this.lb_TenNCC.AutoSize = true;
            this.lb_TenNCC.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNCC.Location = new System.Drawing.Point(78, 139);
            this.lb_TenNCC.Name = "lb_TenNCC";
            this.lb_TenNCC.Size = new System.Drawing.Size(77, 19);
            this.lb_TenNCC.TabIndex = 28;
            this.lb_TenNCC.Text = "Tên NCC:";
            this.lb_TenNCC.Visible = false;
            // 
            // lb_MaNCC
            // 
            this.lb_MaNCC.AutoSize = true;
            this.lb_MaNCC.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNCC.Location = new System.Drawing.Point(81, 104);
            this.lb_MaNCC.Name = "lb_MaNCC";
            this.lb_MaNCC.Size = new System.Drawing.Size(74, 19);
            this.lb_MaNCC.TabIndex = 27;
            this.lb_MaNCC.Text = "Mã NCC:";
            this.lb_MaNCC.Visible = false;
            // 
            // lb_NCC
            // 
            this.lb_NCC.AutoSize = true;
            this.lb_NCC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NCC.ForeColor = System.Drawing.Color.Red;
            this.lb_NCC.Location = new System.Drawing.Point(307, 43);
            this.lb_NCC.Name = "lb_NCC";
            this.lb_NCC.Size = new System.Drawing.Size(176, 24);
            this.lb_NCC.TabIndex = 26;
            this.lb_NCC.Text = "THÔNG TIN NCC";
            this.lb_NCC.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Image = global::QLShowRoomOto_MaiLeDuan.Properties.Resources.inventory;
            this.pb_Avatar.Location = new System.Drawing.Point(518, 101);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(152, 182);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Avatar.TabIndex = 38;
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
            this.progressBar1.Location = new System.Drawing.Point(363, 258);
            this.progressBar1.Maximum = ((long)(100));
            this.progressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(130, 130);
            this.progressBar1.TabIndex = 45;
            this.progressBar1.Text = "0";
            this.progressBar1.Value = ((long)(0));
            // 
            // lb_Anh
            // 
            this.lb_Anh.AutoSize = true;
            this.lb_Anh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Anh.Location = new System.Drawing.Point(459, 101);
            this.lb_Anh.Name = "lb_Anh";
            this.lb_Anh.Size = new System.Drawing.Size(41, 19);
            this.lb_Anh.TabIndex = 47;
            this.lb_Anh.Text = "Ảnh:";
            this.lb_Anh.Visible = false;
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
            this.btn_ThemAnh.TabIndex = 51;
            this.btn_ThemAnh.Text = "Thêm ảnh";
            this.btn_ThemAnh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ThemAnh.UseAccentColor = false;
            this.btn_ThemAnh.UseVisualStyleBackColor = true;
            this.btn_ThemAnh.Visible = false;
            this.btn_ThemAnh.Click += new System.EventHandler(this.btn_ThemAnh_Click);
            // 
            // frm_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 649);
            this.Controls.Add(this.btn_ThemAnh);
            this.Controls.Add(this.lb_Anh);
            this.Controls.Add(this.lb_DanhSach);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DanhSach);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_TenNCC);
            this.Controls.Add(this.tb_MaNCC);
            this.Controls.Add(this.lb_GhiChu);
            this.Controls.Add(this.lb_TenNCC);
            this.Controls.Add(this.lb_MaNCC);
            this.Controls.Add(this.lb_NCC);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pb_Avatar);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_NhaCungCap";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DanhSach;
        private MaterialSkin.Controls.MaterialButton btn_Dong;
        private MaterialSkin.Controls.MaterialButton btn_Xoa;
        private MaterialSkin.Controls.MaterialButton btn_Sua;
        private MaterialSkin.Controls.MaterialButton btn_Them;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_TenNCC;
        private System.Windows.Forms.TextBox tb_MaNCC;
        private System.Windows.Forms.Label lb_GhiChu;
        private System.Windows.Forms.Label lb_TenNCC;
        private System.Windows.Forms.Label lb_MaNCC;
        private System.Windows.Forms.Label lb_NCC;
        private CircularProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.Label lb_Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private MaterialSkin.Controls.MaterialButton btn_ThemAnh;
    }
}