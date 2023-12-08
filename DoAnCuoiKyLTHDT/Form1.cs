using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCuoiKyLTHDT
{
    public partial class Login : Form
    {

        DoAnCuoiKyLTHDTEntities2 db = new DoAnCuoiKyLTHDTEntities2 ();

        private Point lastLocation;

        public Login()
        {
            InitializeComponent();
        }

        private void lblDangKyO_Click(object sender, EventArgs e)
        {
            this.Hide();
            lastLocation = this.Location;
            DKOKTX f = new DKOKTX();
            
            f.StartPosition = FormStartPosition.Manual;
            f.Location = lastLocation;

            f.ShowDialog();

            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //check người đn vào là quản lý hay sinh viên
            bool sv = db.SinhViens.Any(x=> x.Masv == txtMaDN.Text && x.MK == txtMatKhau.Text);
            bool ql = db.QuanLies.Any(x => x.MaQL == txtMaDN.Text && x.MK == txtMatKhau.Text);

            lastLocation = this.Location;
            this.Hide();
            if (sv)
            {
                GiaoDienSV f = new GiaoDienSV();

                f.StartPosition = FormStartPosition.Manual;
                f.Location = lastLocation;
                f.ShowDialog();
            }
            else if (ql)
            {
                GiaoDienQuanLy q = new GiaoDienQuanLy();
                q.StartPosition = FormStartPosition.Manual;
                q.Location = lastLocation;
                q.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa Có Tài Khoản Hoặc Sai Ma/MK");
            }



        }

        private void QuenMK_Click(object sender, EventArgs e)
        {
            lastLocation = this.Location;
            this.Hide();

            LayLaiMK f = new LayLaiMK();

            f.StartPosition = FormStartPosition.Manual;
            f.Location = lastLocation;
            f.ShowDialog();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }


    }
}
