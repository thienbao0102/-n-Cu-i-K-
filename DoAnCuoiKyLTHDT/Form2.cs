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
    public partial class DKOKTX : Form
    {
        DoAnCuoiKyLTHDTEntities2 db = new DoAnCuoiKyLTHDTEntities2();
        private Point lastLocation;
        public DKOKTX()
        {
            InitializeComponent();
        }

        private void BackPage_Click(object sender, EventArgs e)
        {

            lastLocation = this.Location;
            this.Hide();

            Login f = new Login();

            f.StartPosition = FormStartPosition.Manual;
            f.Location = lastLocation;

            f.ShowDialog();
            
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Chưa Nhập Họ Tên");
                return;
            }
            else if(string.IsNullOrEmpty(txtMSSV.Text) || string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Chưa Nhập Mã Số Sinh VIên");
                return;
            }
            else if (string.IsNullOrEmpty(txtLop.Text) || string.IsNullOrWhiteSpace(txtLop.Text))
            {
                MessageBox.Show("Chưa Nhập Lớp");
                return;
            }
            else if (string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Chưa Nhập Số Điện Thoại");
                return;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Chưa Nhập Email");
                return;
            }
            else if(string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Chưa Nhập Mật Khẩu");
                return;
            }
            else if(txtNgayVaoO.Value.Year - txtNgaySinh.Value.Year < 18)
            {
                MessageBox.Show("Em Chưa 18");
                return;
            }    

            //kiểm tra đã tồn tại mã dk chưa
            List<DangKyO> check;
            int maDK;
            do
            {
                Random rnd = new Random();
                maDK = rnd.Next(1, 100000);
                check = db.DangKyOes.Where(x => x.MaDK == maDK).ToList();
            } while (check.Count > 0);

            //khởi tạo đối tượng đk và gán giá trị
            DangKyO svdk = new DangKyO();

            svdk.MaDK = maDK;
            svdk.TenSV= txtHoTen.Text;
            svdk.Masv = txtMSSV.Text;
            svdk.Lop = txtLop.Text;
            svdk.SDT = txtSDT.Text;
            svdk.email = txtEmail.Text;
            svdk.MK = txtMatKhau.Text;
            svdk.NgaySinh = txtNgaySinh.Value;
            svdk.NgayVaoO = txtNgayVaoO.Value;
            if (radNam.Checked)
            {
                svdk.GioiTinh = "nam";
            }
            else
            {
                svdk.GioiTinh = "nu";
            }
            if(radPhgThuong.Checked)
            {
                svdk.Phg = 2;
            }
            else
            {
                svdk.Phg = 1;
            }
            svdk.MaQL = "20040201";

            //thêm vào database
            db.DangKyOes.Add(svdk);
            db.SaveChanges();
            MessageBox.Show("Đăng Ký Thành Công. Chờ Quản Lý Xét Duyệt");
        }
    }
}
