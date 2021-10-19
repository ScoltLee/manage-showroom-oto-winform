using AlertBox;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace QLShowRoomOto_MaiLeDuan
{
    public partial class frm_KhachHang : MaterialForm
    {
        LOPDUNGCHUNG chung;
        ResourceManager rm;
        string imageLocation = Directory.GetCurrentDirectory() + "\\Resources\\user_default.png";
        public frm_KhachHang()
        {
            chung = new LOPDUNGCHUNG();
            InitializeComponent();
            timer1.Start();
            ActiveControl = tb_MaKH;
            chung.GiaoDien(this);
            chung.Avatar(this);
            updateDataGrid();
            updateUIGrid();
        }

        private void updateUIGrid()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dgv_DanhSach.Columns)
                c.DefaultCellStyle.Font = new Font("Time New Roman", 10F, FontStyle.Regular);

            dgv_DanhSach.ColumnHeadersDefaultCellStyle.Font = new Font("Time New Roman", 11F, FontStyle.Regular);
            dgv_DanhSach.Columns[0].Width = dgv_DanhSach.Width - 130 * 4;
            dgv_DanhSach.Columns[1].Width = dgv_DanhSach.Width - 125 * 4;
            dgv_DanhSach.Columns[2].Width = dgv_DanhSach.Width - 140 * 4;
            dgv_DanhSach.Columns[3].Width = dgv_DanhSach.Width - 135 * 4;
            dgv_DanhSach.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_DanhSach.Columns[4].Width = dgv_DanhSach.Width - dgv_DanhSach.Columns[0].Width - dgv_DanhSach.Columns[1].Width - dgv_DanhSach.Columns[2].Width - dgv_DanhSach.Columns[3].Width;
        }

        private void updateDataGrid()
        {
            dgv_DanhSach.DataSource = chung.LoadDuLieu("SELECT MaKH, HoTen, GioiTinh, NgaySinh, DiaChi FROM KHACHHANG");
        }



        private void timer1_Tick(object sender, System.EventArgs e)
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
            progressBar1.Visible = false;
            dgv_DanhSach.Visible = true;
            tb_HoTen.Visible = true;
            tb_MaKH.Visible = true;
            lb_DanhSach.Visible = true;
            lb_GioiTinh.Visible = true;
            lb_NgaySinh.Visible = true;
            lb_HoTen.Visible = true;
            lb_MaKH.Visible = true;
            lb_TTKH.Visible = true;
            lb_DiaChi.Visible = true;
            lb_Anh.Visible = true;
            tb_DiaChi.Visible = true;
            cb_GioiTinh.Visible = true;
            date_NgaySinh.Visible = true;
            btn_Them.Visible = true;
            btn_Sua.Visible = true;
            btn_Xoa.Visible = true;
            btn_Dong.Visible = true;
            btn_ThemAnh.Visible = true;
            pb_Avatar.Visible = true;
        }

        private void btn_Them_Click(object sender, System.EventArgs e)
        {
            if (tb_MaKH.Text.Equals(""))
            {
                chung.Alert("Mã khách hàng không thể để trống.", frm_Alert.enmType.Warning);
            }
            else
            if (!kiemTraKH())
            {

                int result = chung.ThemSuaXoa("INSERT INTO KHACHHANG VALUES('" + tb_MaKH.Text + "',N'" + tb_HoTen.Text + "',N'" + cb_GioiTinh.SelectedValue + "',Convert(datetime,'" + date_NgaySinh.Text + "',103), N'" + tb_DiaChi.Text + "',@image)", chung.ChuyenDoiAnh(imageLocation));

                if (result >= 1)
                {
                    chung.Alert("Thêm thành công", frm_Alert.enmType.Success);
                    updateDataGrid();
                }
                else
                    chung.Alert("Thêm thất bại", frm_Alert.enmType.Error);
            }
            else
            {
                chung.Alert("Mã khách hàng đã tồn tại", frm_Alert.enmType.Error);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (tb_MaKH.Text.Equals(""))
            {
                chung.Alert("Mã khách hàng không thể để trống.", frm_Alert.enmType.Warning);
            }
            else
            {

                if (kiemTraKH())
                {
                    var dialogResult = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
                    DialogResult dt = chung.ThongBao("Cảnh Báo", "Bạn thật sự muốn xoá?", System.Drawing.SystemIcons.Warning, dialogResult);
                    if (dt == DialogResult.OK)
                    {
                        int result = chung.ThemSuaXoa("DELETE KHACHHANG WHERE [MaKH] = '" + tb_MaKH.Text + "'",null);

                        if (result >= 1)
                        {
                            chung.Alert("Xoá thành công", frm_Alert.enmType.Success);
                            updateDataGrid();
                        }
                        else
                            chung.Alert("Xoá thất bại", frm_Alert.enmType.Error);
                    }
                }
                else
                {
                    chung.Alert("Mã khách hàng không tồn tại", frm_Alert.enmType.Error);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_MaKH.Text.Equals(""))
            {
                chung.Alert("Mã khách hàng không thể để trống.", frm_Alert.enmType.Warning);
            }
            else
            if (kiemTraKH())
            {
                int result = chung.ThemSuaXoa("UPDATE KHACHHANG SET [HoTen] = N'" + tb_HoTen.Text + "',[GioiTinh] = N'" + cb_GioiTinh.Text + "',[NgaySinh] = Convert(datetime,'" + date_NgaySinh.Text + "',103),[DiaChi] = N'" + tb_DiaChi.Text + "', [Anh] = @image WHERE [MaKH] = '" + tb_MaKH.Text + "'", chung.ChuyenDoiAnh(imageLocation));

                if (result >= 1)
                {
                    updateDataGrid();
                    chung.Alert("Cập nhật thành công", frm_Alert.enmType.Success);
                }
                else
                    chung.Alert("Cập nhật thất bại", frm_Alert.enmType.Error);
            }
            else
            {
                chung.Alert("Mã khách hàng không tồn tại", frm_Alert.enmType.Error);
            }
        }
        private bool kiemTraKH()
        {
            int result = (int)chung.TraVeGT("SELECT COUNT([MaKH]) FROM KHACHHANG WHERE [MaKH] = '" + tb_MaKH.Text + "'");
            if (result >= 1)
                return true;
            else
                return false;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            chung.Dong(sender, e, this);
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaKH.Text = dgv_DanhSach.CurrentRow.Cells["MaKH"].Value.ToString();
            tb_HoTen.Text = dgv_DanhSach.CurrentRow.Cells["HoTen"].Value.ToString();
            cb_GioiTinh.SelectedValue = dgv_DanhSach.CurrentRow.Cells["GioiTinh"].Value.ToString();
            tb_DiaChi.Text = dgv_DanhSach.CurrentRow.Cells["DiaChi"].Value.ToString();
            date_NgaySinh.Text = dgv_DanhSach.CurrentRow.Cells["NgaySinh"].Value.ToString();        
            chung.XemAnh("SELECT Anh FROM KHACHHANG WHERE MaKH = '" + tb_MaKH.Text + "'", pb_Avatar);
        }

        private void btn_ThemAnh_Click(object sender, EventArgs e)
        {
            imageLocation = chung.ThemAnh(imageLocation, pb_Avatar);
        }

        public void LoadComBoGT()
        {           
            string sql = "SELECT * FROM (VALUES (N'Không rõ'), ('Nam'), (N'Nữ')) AS GIOITINH(element)";
            cb_GioiTinh.DataSource = chung.LoadDuLieu(sql);
            cb_GioiTinh.DisplayMember = "element";
            cb_GioiTinh.ValueMember = "element";
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadComBoGT();
        }
    }
}
