using AlertBox;
using DevExpress.XtraEditors;
using QLShowRoomOto_MaiLeDuan.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLShowRoomOto_MaiLeDuan
{
    class LOPDUNGCHUNG
    {
        SqlConnection conn;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public LOPDUNGCHUNG()
        {
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\QLShowRoomOto_MaiLeDuan\QLShowRoomOto_MaiLeDuan\ShowRoomOto.mdf;Integrated Security=True";
        }
        public int ThemSuaXoa(String sql, byte[] image)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            if (image != null)
                comm.Parameters.Add(new SqlParameter("@image", image));
            conn.Open();
            int result = comm.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public object TraVeGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object result = comm.ExecuteScalar();
            conn.Close();
            return result;
        }

        public DataTable LoadDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void GiaoDien(MaterialSkin.Controls.MaterialForm frm)
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(frm);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        public DialogResult ThongBao(string cap, string text, Icon icon, DialogResult[] dialogResults)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = cap;
            args.Text = text;
            args.Buttons = dialogResults;
            args.Icon = icon;
            args.Showing += Args_Showing;
            DialogResult dt = XtraMessageBox.Show(args);
            return dt;
        }

        public void Args_Showing(object sender, XtraMessageShowingArgs e)
        {

            foreach (var control in e.Form.Controls)
            {
                SimpleButton button = control as SimpleButton;
                if (button != null)
                {
                    button.ImageOptions.SvgImageSize = new Size(16, 16);
                    button.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter;
                    switch (button.DialogResult)
                    {
                        case (DialogResult.OK):
                            button.Image = Resources.ok_btn;
                            break;
                        case (DialogResult.Cancel):
                            button.Image = Resources.cancel_btn;
                            break;
                    }
                }
            }
        }

        public void Avatar(MaterialSkin.Controls.MaterialForm frm)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Oto));
            System.Windows.Forms.PictureBox pb_Avatar;
            pb_Avatar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pb_Avatar)).BeginInit();
            pb_Avatar.Image = (Image)resources.GetObject("pb_Avatar.Image");
            pb_Avatar.Location = new System.Drawing.Point(536, 125);
            pb_Avatar.Name = "pb_Avatar";
            pb_Avatar.Size = new System.Drawing.Size(152, 182);
            pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb_Avatar.TabIndex = 5;
            pb_Avatar.TabStop = false;
            frm.Controls.Add(pb_Avatar);
            pb_Avatar.Visible = false;
        }

        public void Alert(string msg, frm_Alert.enmType type)
        {
            frm_Alert frm = new frm_Alert();
            frm.showAlert(msg, type);
        }

        public void Dong(object sender, EventArgs e, MaterialSkin.Controls.MaterialForm frm)
        {
            var dialogResult = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            DialogResult dt = ThongBao("Cảnh Báo", "Bạn thật sự muốn thoát?", System.Drawing.SystemIcons.Question, dialogResult);
            if (dt == DialogResult.OK)
                frm.Close();
        }

        public void XemAnh(string sql, PictureBox pb)
        {
            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();
            SqlDataReader dataReader = comm.ExecuteReader();
            dataReader.Read();
            
            if (dataReader.HasRows)
            {
                byte[] image = ((byte[])dataReader[0]);
                if (image == null)
                    pb.Image = null;
                else
                {
                    MemoryStream memory = new MemoryStream(image);
                    pb.Image = Image.FromStream(memory);
                }
            }
            conn.Close();
        }

        public byte[] ChuyenDoiAnh(string imageLocation)
        {
            if (imageLocation != null)
            {
                byte[] images = null;
                FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                return images;
            }
            return null;
        }

        public string ThemAnh(string imageLocation, PictureBox pb_Avatar)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pb_Avatar.ImageLocation = dialog.FileName;
                imageLocation = dialog.FileName;
            }
            return imageLocation;
        }

        public void Popup(MaterialSkin.Controls.MaterialForm frm, Point location)
        {
            Form formBackground = new Form();
            try
            {                            
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    frm.Owner = formBackground;
                    frm.ShowDialog();
                    formBackground.Dispose();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
    }

}
