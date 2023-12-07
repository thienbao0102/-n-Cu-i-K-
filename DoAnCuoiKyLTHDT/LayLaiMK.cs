using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKyLTHDT
{
    public partial class LayLaiMK : Form
    {
        DoAnCuoiKyLTHDTEntities1 db = new DoAnCuoiKyLTHDTEntities1();
        private Point lastLocation;
        private string maXT;
        public LayLaiMK()
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

        private void btnGuiMaXN_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Chưa Nhập Email");
                return;
            }
            if (string.IsNullOrEmpty(txtMK.Text) || string.IsNullOrWhiteSpace(txtMK.Text)
                || string.IsNullOrEmpty(txtReMK.Text) || string.IsNullOrWhiteSpace(txtReMK.Text))
            {
                MessageBox.Show("Chưa Nhập Mật Khẩu Hoặc Chưa Nhập Lại Mật Khẩu");
                return;
            }
            if (txtMK.Text != txtReMK.Text)
            {
                MessageBox.Show("Mật Khẩu Không Giống Nhau");
                return;
            }
            Random rd = new Random();
            maXT = rd.Next(100000, 999999).ToString();
            //taoj noi dung cho mail
            MailMessage message = new MailMessage("severnobita12345@gmail.com", txtEmail.Text, "Mã Xác Thực", maXT);

            //tao noi gui mail
            SmtpClient client = new SmtpClient("smtp.gmail.com",587);

            //dang nhap gmail de gui
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("severnobita12345@gmail.com", "xmcy saty fpxr ovfq");
            

            
            try
            {
                client.Send(message);

                MessageBox.Show("Đã Gửi Mã Xác Thực");
            }
            catch (Exception)
            {
                MessageBox.Show("Gửi Lỗi");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaXN.Text) || string.IsNullOrWhiteSpace(txtMaXN.Text))
            {
                MessageBox.Show("Chưa Nhập Mã Xác Nhận");
                return;
            }
            if(txtMaXN.Text != maXT)
            {
                MessageBox.Show("Sai Mã Xác Thực");
                return;
            }
            List<SinhVien> a = db.SinhViens.Where(b=> b.email == txtEmail.Text).ToList();

            SinhVien sv = a[0];
            sv.MK = txtMK.Text;

            db.SaveChanges();
            MessageBox.Show("Đổi Mật Khẩu Thành Công");
        }
    }
}
