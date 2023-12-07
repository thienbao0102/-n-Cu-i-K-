using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKyLTHDT
{
    public partial class Login : Form
    {

        DoAnCuoiKyLTHDTEntities db = new DoAnCuoiKyLTHDTEntities();

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
            bool sv = db.SinhViens.Any(x=> x.Masv == txtMaDN.Text && x.MK == txtMatKhau.Text);

            if (sv == false )
            {
                MessageBox.Show("Chưa Có Tài Khoản Hoặc Sai MaSV/MK");
                return;
            }
            lastLocation = this.Location;
            this.Hide();

            GiaoDienSV f = new GiaoDienSV();

            f.StartPosition = FormStartPosition.Manual;
            f.Location = lastLocation;
            f.ShowDialog();
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
    }
}
