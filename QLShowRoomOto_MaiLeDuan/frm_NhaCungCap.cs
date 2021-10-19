using AlertBox;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace QLShowRoomOto_MaiLeDuan
{
    public partial class frm_NhaCungCap : MaterialForm
    {
        LOPDUNGCHUNG chung;
        ResourceManager rm;
        string imageLocation = Directory.GetCurrentDirectory() + "\\Resources\\inventory.png";
        public frm_NhaCungCap()
        {
            chung = new LOPDUNGCHUNG();
            InitializeComponent();
            timer1.Start();
            this.ActiveControl = tb_MaNCC;
            chung.GiaoDien(this);
            chung.Avatar(this);
            updateDataGrid();
            updateUIGrid();

        }
        private void updateUI()
        {
            progressBar1.Visible = false;
            lb_NCC.Visible = true;
            lb_MaNCC.Visible = true;
            lb_TenNCC.Visible = true;
            lb_Anh.Visible = true;
            tb_MaNCC.Visible = true;
            tb_TenNCC.Visible = true;
            tb_DiaChi.Visible = true;
            dgv_DanhSach.Visible = true;
            lb_DanhSach.Visible = true;
            lb_GhiChu.Visible = true;
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
            {
                c.DefaultCellStyle.Font = new Font("Time New Roman", 10F, FontStyle.Regular);
            }
            dgv_DanhSach.ColumnHeadersDefaultCellStyle.Font = new Font("Time New Roman", 11F, FontStyle.Regular);
            dgv_DanhSach.Columns[0].Width = dgv_DanhSach.Width - 135 * 4;
            dgv_DanhSach.Columns[1].Width = dgv_DanhSach.Width - 135 * 4;
            dgv_DanhSach.Columns[2].Width = dgv_DanhSach.Width - dgv_DanhSach.Columns[0].Width - dgv_DanhSach.Columns[1].Width;

        }

        private void updateDataGrid()
        {
            dgv_DanhSach.DataSource = chung.LoadDuLieu("SELECT MaNCC, TenNCC, DiaChi FROM NCC");
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

        private void btn_Them_Click(object sender, System.EventArgs e)
        {
            if (tb_MaNCC.Text.Equals(""))
            {
                chung.Alert("Mã nhà cung cấp không thể để trống.", frm_Alert.enmType.Warning);
            }
            else
            if (!kiemTrMK())
            {
                int result = chung.ThemSuaXoa("INSERT INTO NCC VALUES('" + tb_MaNCC.Text + "',N'" + tb_TenNCC.Text + "',N'" + tb_DiaChi.Text + "',@image)", chung.ChuyenDoiAnh(imageLocation));
                updateDataGrid();
                if (result >= 1)
                    chung.Alert("Thêm thành công", frm_Alert.enmType.Success);
                else
                    chung.Alert("Thêm thất bại", frm_Alert.enmType.Error);
            }
            else
            {
                chung.Alert("Mã nhà cung cấp đã tồn tại", frm_Alert.enmType.Error);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_MaNCC.Text.Equals(""))
            {
                chung.Alert("Mã nhà cung cấp không thể để trống.", frm_Alert.enmType.Warning);
            }
            else
            {

                if (kiemTrMK())
                {
                    var dialogResult = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
                    DialogResult dt = chung.ThongBao("Cảnh Báo", "Bạn thật sự muốn xoá?", System.Drawing.SystemIcons.Warning, dialogResult);
                    if (dt == DialogResult.OK)
                    {
                        int result = chung.ThemSuaXoa("DELETE NCC WHERE [MaNCC] = '" + tb_MaNCC.Text + "'", null);
                        updateDataGrid();
                        if (result >= 1)
                            chung.Alert("Xoá thành công", frm_Alert.enmType.Success);
                        else
                            chung.Alert("Xoá thất bại", frm_Alert.enmType.Error);
                    }
                }
                else
                {
                    chung.Alert("Mã nhà cung cấp không tồn tại", frm_Alert.enmType.Error);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_MaNCC.Text.Equals(""))
            {
                chung.Alert("Mã nhà cung cấp không thể để trống.", frm_Alert.enmType.Warning);
            }
            else
            if (kiemTrMK())
            {
                int result = chung.ThemSuaXoa("UPDATE NCC SET [TenNCC] = N'" + tb_TenNCC.Text + "',[DiaChi] = N'" + tb_DiaChi.Text + "', [Anh] = @image WHERE [MaNCC] = '" + tb_MaNCC.Text + "'", chung.ChuyenDoiAnh(imageLocation));
                updateDataGrid();
                if (result >= 1)
                    chung.Alert("Cập nhật thành công", frm_Alert.enmType.Success);
                else
                    chung.Alert("Cập nhật thất bại", frm_Alert.enmType.Error);
            }
            else
            {
                chung.Alert("Mã nhà cung cấp không tồn tại", frm_Alert.enmType.Error);
            }
        }

        private bool kiemTrMK()
        {

            int result = (int)chung.TraVeGT("SELECT COUNT([MaNCC]) FROM NCC WHERE [MaNCC] = '" + tb_MaNCC.Text + "'");
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
            tb_MaNCC.Text = dgv_DanhSach.CurrentRow.Cells["MaNCC"].Value.ToString();
            tb_TenNCC.Text = dgv_DanhSach.CurrentRow.Cells["TenNCC"].Value.ToString();
            tb_DiaChi.Text = dgv_DanhSach.CurrentRow.Cells["DiaChi"].Value.ToString();
            chung.XemAnh("SELECT Anh FROM NCC WHERE MaNCC = '" + tb_MaNCC.Text + "'", pb_Avatar);
        }

        private void btn_ThemAnh_Click(object sender, EventArgs e)
        {
            imageLocation = chung.ThemAnh(imageLocation, pb_Avatar);
        }
    }
}
