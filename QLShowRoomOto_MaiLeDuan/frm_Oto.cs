using AlertBox;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using QLShowRoomOto_MaiLeDuan.Properties;
using System.Resources;
using System.IO;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QLShowRoomOto_MaiLeDuan
{
    public partial class frm_Oto : MaterialForm
    {
        LOPDUNGCHUNG chung;
        ResourceManager rm;
        string imageLocation = Directory.GetCurrentDirectory() + "\\Resources\\car_default.png";
        public frm_Oto()
        {
            chung = new LOPDUNGCHUNG();
            rm = Resources.ResourceManager;
            InitializeComponent();
            timer1.Start();
            ActiveControl = tb_MaXe;
            chung.GiaoDien(this);
            chung.Avatar(this);
            updateDataGrid();
            updateUIGrid();
        }

        private void updateUI()
        {
            progressBar1.Visible = false;
            lb_TTOT.Visible = true;
            lb_MaXe.Visible = true;
            lb_TenXe.Visible = true;
            lb_NgayNhap.Visible = true;
            lb_SoLuong.Visible = true;
            lb_NSX.Visible = true;
            lb_NCC.Visible = true;
            tb_MaXe.Visible = true;
            tb_NSX.Visible = true;
            tb_Ten.Visible = true;
            lb_Anh.Visible = true;
            tb_SoLuong.Visible = true;
            cb_NCC.Visible = true;
            dgv_DanhSach.Visible = true;
            lb_DanhSach.Visible = true;
            date_NgayNhap.Visible = true;
            btn_Them.Visible = true;
            btn_Sua.Visible = true;
            btn_Xoa.Visible = true;
            btn_Dong.Visible = true;
            btn_ThemAnh.Visible = true;
            pb_Avatar.Visible = true;
        }

        private void updateUIGrid()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dgv_DanhSach.Columns)
                c.DefaultCellStyle.Font = new Font("Time New Roman", 10F, FontStyle.Regular);

            dgv_DanhSach.ColumnHeadersDefaultCellStyle.Font = new Font("Time New Roman", 11F, FontStyle.Regular);
            dgv_DanhSach.Columns[0].Width = dgv_DanhSach.Width - 147 * 4;
            dgv_DanhSach.Columns[1].Width = dgv_DanhSach.Width - 130 * 4;
            dgv_DanhSach.Columns[2].Width = dgv_DanhSach.Width - 145 * 4;
            dgv_DanhSach.Columns[3].Width = dgv_DanhSach.Width - 145 * 4;
            dgv_DanhSach.Columns[4].Width = dgv_DanhSach.Width - 140 * 4;
            dgv_DanhSach.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_DanhSach.Columns[5].Width = dgv_DanhSach.Width - dgv_DanhSach.Columns[0].Width - dgv_DanhSach.Columns[1].Width - dgv_DanhSach.Columns[2].Width - dgv_DanhSach.Columns[3].Width - dgv_DanhSach.Columns[4].Width;         
        }

        private void updateDataGrid()
        {
            dgv_DanhSach.DataSource = chung.LoadDuLieu("SELECT MaXe, Ten, NSX, NCC, NgayNhap, SoLuong FROM OTO");

        }

        private void btn_Them_Click(object sender, System.EventArgs e)
        {
            if (tb_MaXe.Text.Equals(""))
            {
                chung.Alert("Mã xe không thể để trống.", frm_Alert.enmType.Warning);
            }
            else
            if (!kiemTraXe())
            {

                int result = chung.ThemSuaXoa("INSERT INTO OTO VALUES('" + tb_MaXe.Text + "',N'" + tb_Ten.Text + "',N'" + tb_NSX.Text + "',N'" + cb_NCC.SelectedValue + "',Convert(datetime,'" + date_NgayNhap.Text + "',103), N'" + tb_SoLuong.Text + "',@image)", chung.ChuyenDoiAnh(imageLocation));

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
                chung.Alert("Mã xe đã tồn tại", frm_Alert.enmType.Error);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (tb_MaXe.Text.Equals(""))
            {
                chung.Alert("Mã xe không thể để trống.", frm_Alert.enmType.Warning);
            }
            else
            {

                if (kiemTraXe())
                {
                    var dialogResult = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
                    DialogResult dt = chung.ThongBao("Cảnh Báo", "Bạn thật sự muốn xoá?", System.Drawing.SystemIcons.Warning, dialogResult);
                    if (dt == DialogResult.OK)
                    {
                        int result = chung.ThemSuaXoa("DELETE OTO WHERE [MaXe] = '" + tb_MaXe.Text + "'", null);

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
                    chung.Alert("Mã xe không tồn tại", frm_Alert.enmType.Error);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_MaXe.Text.Equals(""))
            {
                chung.Alert("Mã xe không thể để trống.", frm_Alert.enmType.Warning);
            }
            else
            if (kiemTraXe())
            {
                int result = chung.ThemSuaXoa("UPDATE OTO SET [Ten] = N'" + tb_Ten.Text + "',[NSX] = N'" + tb_NSX.Text + "',[NCC] = N'" + cb_NCC.SelectedValue + "',[NgayNhap] = Convert(datetime,'" + date_NgayNhap.Text + "',103),[SoLuong] = N'" + tb_SoLuong.Text + "', [Anh] = @image WHERE [MaXe] = '" + tb_MaXe.Text + "'", chung.ChuyenDoiAnh(imageLocation));

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
                chung.Alert("Mã xe không tồn tại", frm_Alert.enmType.Error);
            }
        }
        private bool kiemTraXe()
        {
            int result = (int)chung.TraVeGT("SELECT COUNT([MaXe]) FROM OTO WHERE [MaXe] = '" + tb_MaXe.Text + "'");
            if (result >= 1)
                return true;
            else
                return false;
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

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            chung.Dong(sender, e, this);
        }

        public void LoadComBoNCC()
        {
            string sql = "SELECT * FROM NCC";
            cb_NCC.DataSource = chung.LoadDuLieu(sql);
            cb_NCC.DisplayMember = "TenNCC";
            cb_NCC.ValueMember = "MaNCC";
        }
        private void frm_Oto_Load(object sender, EventArgs e)
        {
            LoadComBoNCC();
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaXe.Text = dgv_DanhSach.CurrentRow.Cells["MaXe"].Value.ToString();
            tb_Ten.Text = dgv_DanhSach.CurrentRow.Cells["Ten"].Value.ToString();
            tb_NSX.Text = dgv_DanhSach.CurrentRow.Cells["NSX"].Value.ToString();
            tb_SoLuong.Text = dgv_DanhSach.CurrentRow.Cells["SoLuong"].Value.ToString();
            date_NgayNhap.Text = dgv_DanhSach.CurrentRow.Cells["NgayNhap"].Value.ToString();
            cb_NCC.SelectedValue = dgv_DanhSach.CurrentRow.Cells["NCC"].Value.ToString();
            chung.XemAnh("SELECT Anh FROM OTO WHERE MaXe = '" + tb_MaXe.Text + "'", pb_Avatar);
        }

        private void btn_ThemAnh_Click(object sender, EventArgs e)
        {
            imageLocation = chung.ThemAnh(imageLocation, pb_Avatar);
        }
    }
}
