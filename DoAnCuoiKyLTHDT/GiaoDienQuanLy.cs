using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace DoAnCuoiKyLTHDT
{
    public partial class GiaoDienQuanLy : Form
    {

        DoAnCuoiKyLTHDTEntities2 db = new DoAnCuoiKyLTHDTEntities2 ();
        List<Phong> dsPhg = new List<Phong>();
        List<SinhVien> dssv = new List<SinhVien>();
        List<ThanNhan> dstn = new List<ThanNhan>();
        List<DangKyO> dsdk = new List<DangKyO>();
        List<HoaDon> dshoadon = new List<HoaDon>();
        List<ThietBi> dsthietbi = new List<ThietBi>();
        private int index;
        public GiaoDienQuanLy()
        {
            InitializeComponent();
        }

        private void GiaoDienQuanLy_Load(object sender, EventArgs e)
        {
            //hiện thị danh sách phòng lên lưới
            dsPhg = db.Phongs.ToList();
            ShowDSPhg(dsPhg, dtgvPhg);

            //hiện thị thong tin phòng đầu tiên lên lưới
            txtMaPhg.Text = dsPhg[0].MaPhg.ToString();
            txtGiaTien.Text = dsPhg[0].GiaTien.ToString();
            txtSoGiuong.Text = dsPhg[0].SoGiuong + "";
            txtSoNguoi.Text = dsPhg[0].SinhViens.Count + "";
            txtLoaiPhg.Text = dsPhg[0].LoaiPhg;

            //hiện thị danh sách thông tin sinh vien ở phòng đầu
            dssv = dsPhg[0].SinhViens.ToList();
            ShowDSSV(dssv, dtgvSVTrongPhg);
        }

        private void ShowDSPhg(List<Phong> dsPhg, object sender)
        {
            DataGridView a = (DataGridView)sender;
            a.DataSource = dsPhg;
            a.Columns[4].Width = 0;
            a.Columns[4].Visible = false;
            a.Columns[5].Width = 0;
            a.Columns[5].Visible = false;
            a.Columns[6].Width = 0;
            a.Columns[6].Visible = false;
            a.Columns[0].Width = 194;
            a.Columns[1].Width = 194;
            a.Columns[2].Width = 194;
            a.Columns[3].Width = 194;
        }

        private void ShowDSSV(List<SinhVien> dssv, object sender)
        {
            DataGridView a = (DataGridView) sender;
            a.DataSource = dssv;
            a.Columns[8].Width = 0;
            a.Columns[8].Visible = false;
            a.Columns[9].Width = 0;
            a.Columns[9].Visible = false;
            a.Columns[10].Width = 0;
            a.Columns[10].Visible = false;
            a.Columns[11].Width = 0;
            a.Columns[11].Visible = false;
            a.Columns[12].Width = 0;
            a.Columns[12].Visible = false;

        }
        private void ShowDSHD(List<HoaDon> dshd, object sender)
        {
            DataGridView a = (DataGridView)sender;
            a.DataSource = dshd;
            a.Columns[5].Width = 0;
            a.Columns[5].Visible = false;
            a.Columns[6].Width = 0;
            a.Columns[6].Visible = false;
            a.Columns[4].Width = 0;
            a.Columns[4].Visible = false;
            a.Columns[7].Width = 0;
            a.Columns[7].Visible = false;


        }

        //******************************************************************************************************
        //chuc nang quan ly phong
        private void dtgvPhg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > dtgvPhg.Rows.Count || e.RowIndex < 0)
            {
                return;
            }

            //show thong tin len textbox
            txtGiaTien.Text = dsPhg[e.RowIndex].GiaTien.ToString();
            txtLoaiPhg.Text = dsPhg[e.RowIndex].LoaiPhg.ToString();
            txtMaPhg.Text = dsPhg[e.RowIndex].MaPhg.ToString();
            txtSoGiuong.Text = dsPhg[e.RowIndex].SoGiuong.ToString();
            txtSoNguoi.Text = dsPhg[e.RowIndex].SinhViens.Count.ToString();

            //show ds sv trong phong 
            dssv = dsPhg[e.RowIndex].SinhViens.ToList();
            ShowDSSV(dssv, dtgvSVTrongPhg);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(txtThongTinTimKiem.Text) || string.IsNullOrWhiteSpace(txtThongTinTimKiem.Text))
            {
                dsPhg = db.Phongs.ToList();
            }
            else
            {
                int maphong = int.Parse(txtThongTinTimKiem.Text);
                dsPhg = db.Phongs.Where(x=> x.MaPhg == maphong).ToList();
            }
            dssv = dsPhg[0].SinhViens.ToList();
            ShowDSPhg(dsPhg, dtgvPhg);
            ShowDSSV(dssv, dtgvSVTrongPhg);
        }
//******************************************************************************************************
        // chuc nang quan ly sinh vien

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.Lime;
            btnDuyetDKO.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanlyPhong.BackColor = Color.FromArgb(224, 224, 224);
            btnThanhToan.BackColor = Color.FromArgb(224, 224, 224);
            btnQLTB.BackColor = Color.FromArgb(224,224,224);
            btnQuanLyHoaDon.BackColor = Color.FromArgb(224, 224, 224);

            //chuyen hien thi chuc nang
            ChucNangQuanLy.Visible = false;
            ChucNangQLSV.Visible = true;
            ChucNangDKO.Visible = false;
            ChucNangThanhToan.Visible = false;
            ChucNangQLTB.Visible = false;
            ChucNangQLHoaDon.Visible = false;
            //hien thị data lên lưới
            dssv = db.SinhViens.ToList();
            ShowDSSV(dssv, dtgvSinhVien);

            //hien thi nguoi dau tien len o text
            txtMSSV.Text = dssv[0].Masv;
            txtTenSV.Text = dssv[0].TenSV;
            txtSDT.Text = dssv[0].SDT;
            txtNgaySinh.Value = dssv[0].NgaySinh;
            txtNgayVaoO.Value = dssv[0].NgayVaoO;
            txtPhongSV.Text = dssv[0].MaPhg.ToString();
            txtEmail.Text = dssv[0].email;
            txtLopSV.Text = dssv[0].Lop;
            txtGioiTinh.Text = dssv[0].GioiTinh;

            //hien thi than nhan cua sinh vien dau tien
        }

        private void dtgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > dtgvSinhVien.Rows.Count || e.RowIndex < 0) 
                return;

            //hien thi thong tin sv dc chon 
            txtMSSV.Text = dssv[e.RowIndex].Masv;
            txtTenSV.Text = dssv[e.RowIndex].TenSV;
            txtSDT.Text = dssv[e.RowIndex].SDT;
            txtNgaySinh.Value = dssv[e.RowIndex].NgaySinh;
            txtNgayVaoO.Value = dssv[e.RowIndex].NgayVaoO;
            txtPhongSV.Text = dssv[e.RowIndex].MaPhg.ToString();
            txtEmail.Text = dssv[e.RowIndex].email;
            txtLopSV.Text = dssv[e.RowIndex].Lop;
            txtGioiTinh.Text = dssv[e.RowIndex].GioiTinh;
            

            //hien thi than nhan cua sv dc chon
        }

        //tim kiem sinh vien
        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtTimKiemSinhVien.Text);
            //loc danh sach tim kiem
            if(string.IsNullOrEmpty(txtTimKiemSinhVien.Text) || 
                string.IsNullOrWhiteSpace(txtTimKiemSinhVien.Text))
            {
                dssv = db.SinhViens.ToList();
            }
            else
            {
                dssv = db.SinhViens.Where(x =>  x.Masv == txtTimKiemSinhVien.Text 
                    || x.TenSV.Contains(txtTimKiemSinhVien.Text)).ToList();
            }

            //hien thi thong tin sv tim kiem len luoi
            ShowDSSV(dssv, dtgvSinhVien);

            //set text về rỗng
            txtMSSV.Text = "";
            txtTenSV.Text = "";
            txtSDT.Text = "";
            txtNgaySinh.Value = DateTime.Now;
            txtNgayVaoO.Value = DateTime.Now;
            txtPhongSV.Text = "";
            txtEmail.Text = "";
            txtLopSV.Text = "";
            txtGioiTinh.Text = "";

            //hien thi thong tin than nhan cua sinh vien len luoi
        }

 //******************************************************************************************************
        //nut bam cua chuc nang quan ly phong
        private void btnQuanlyPhong_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.FromArgb(224, 224, 224);
            btnDuyetDKO.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanlyPhong.BackColor = Color.Lime;
            btnThanhToan.BackColor = Color.FromArgb(224, 224, 224);
            btnQLTB.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanLyHoaDon.BackColor = Color.FromArgb(224, 224, 224);

            //chuyen hien thi chuc nang
            ChucNangQuanLy.Visible = true;
            ChucNangQLSV.Visible = false;
            ChucNangDKO.Visible = false;
            ChucNangThanhToan.Visible = false;
            ChucNangQLTB.Visible = false;
            ChucNangQLHoaDon.Visible = false;
        }
//******************************************************************************************************
        //chuc nang duyet dk o
        private void btnDuyetDKO_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.FromArgb(224, 224, 224);
            btnDuyetDKO.BackColor = Color.Lime;
            btnQuanlyPhong.BackColor = Color.FromArgb(224, 224, 224);
            btnThanhToan.BackColor = Color.FromArgb(224, 224, 224);
            btnQLTB.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanLyHoaDon.BackColor = Color.FromArgb(224, 224, 224);

            //chuyen hien thi chuc nang
            ChucNangQuanLy.Visible = false;
            ChucNangQLSV.Visible = false;
            ChucNangDKO.Visible = true;
            ChucNangThanhToan.Visible = false;
            ChucNangQLTB.Visible = false;
            ChucNangQLHoaDon.Visible = false;

            //show data leen luoi
            dsdk = db.DangKyOes.ToList();
            dtgvSVDKO.DataSource = dsdk;
            var x = from c in dsdk
                    select new
                    {
                        c.Masv,
                        c.TenSV,
                        c.NgaySinh,
                        c.Lop,
                        c.GioiTinh,
                        c.NgayVaoO,
                        c.SDT,
                        c.email,
                        LoaiPhong = (c.Phg == 1) ? "tốt" : "thường"
                    };
            dtgvSVDKO.DataSource = x.ToList();

            //show phong con trong len lươi
            dsPhg = db.Phongs.Where(a => a.SinhViens.Count < 4 && a.LoaiPhg == "thường").ToList();
            var p = from c in dsPhg
                    select new
                    {
                        c.MaPhg,
                        SoLuong = c.SinhViens.Count
                    };
            dtgvPhgConCho.DataSource = p.ToList();

            // show sv dau tien trong luoi
            if(x.ToList().Count >0)
            {
                txtMSSVDKO.Text = x.ToList()[0].Masv;
                txtTenSVDKO.Text = x.ToList()[0].TenSV;
                txtNgaySinhSVDKO.Value = x.ToList()[0].NgaySinh;
                txtNgayVaoOSVDKO.Value = x.ToList()[0].NgayVaoO;
                txtLoaiPhongSVDKO.Text = x.ToList()[0].LoaiPhong;
                txtSDTSVDKO.Text = x.ToList()[0].SDT;
                txtEmailSVDKO.Text = x.ToList()[0].email;
                txtGioiTinhSVDKO.Text = x.First().GioiTinh;
                txtLopSVDKO.Text = x.First().Lop;
            }
        }

        //chon loai phong
        private void radDKPhgThuong_CheckedChanged(object sender, EventArgs e)
        {
            if(radDKPhgThuong.Checked)
            {
                dsPhg = db.Phongs.Where(a => a.SinhViens.Count < 4 && a.LoaiPhg == "thường").ToList();
                var p = from c in dsPhg
                        select new
                        {
                            c.MaPhg,
                            SoLuong = c.SinhViens.Count
                        };
                dtgvPhgConCho.DataSource = p.ToList();
            }
        }
        private void radDKPhgTot_CheckedChanged(object sender, EventArgs e)
        {
            if(radDKPhgTot.Checked)
            {
                dsPhg = db.Phongs.Where(a => a.SinhViens.Count < 4 && a.LoaiPhg == "tốt").ToList();
                var p = from c in dsPhg
                        select new
                        {
                            c.MaPhg,
                            SoLuong = c.SinhViens.Count
                        };
                dtgvPhgConCho.DataSource = p.ToList();
            }
        }

        //hành động trên luoi show sv đc chọn lên ô text
        private void dtgvSVDKO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > dtgvSVDKO.Rows.Count || e.RowIndex <0)
            {
                return;
            }
            index = e.RowIndex;
            txtMSSVDKO.Text = dsdk[e.RowIndex].Masv;
            txtTenSVDKO.Text = dsdk[e.RowIndex].TenSV;
            txtNgaySinhSVDKO.Value = dsdk[e.RowIndex].NgaySinh;
            txtNgayVaoOSVDKO.Value = dsdk[e.RowIndex].NgayVaoO;
            txtLoaiPhongSVDKO.Text = (dsdk[e.RowIndex].Phg == 2)?"thường":"tốt";
            txtSDTSVDKO.Text = dsdk[e.RowIndex].SDT;
            txtEmailSVDKO.Text = dsdk[e.RowIndex].email;
            txtGioiTinhSVDKO.Text = dsdk[e.RowIndex].GioiTinh;
            txtLopSVDKO.Text = dsdk[e.RowIndex].Lop;

        }

        //chon phong cho sv
        private void dtgvPhgConCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > dtgvPhgConCho.Rows.Count || e.RowIndex < 0)
            { return; }

            //show so phong leen o text

            txtPhongDKChoSV.Text = dsPhg[e.RowIndex].MaPhg + "";
        }

        //nut duyet sv vao o
        private void btnDuyetSVDKO_Click(object sender, EventArgs e)
        {
            if(dsdk.Count == 0)
            {
                MessageBox.Show("Không Có Sinh Viên Nào Để Duyệt");
                return;
            }

            bool checksv = db.SinhViens.Any(a=> a.Masv == txtMSSVDKO.Text || a.TenSV.Contains(txtTenSVDKO.Text));
            if(checksv  && !(string.IsNullOrEmpty(txtTenSVDKO.Text) || string.IsNullOrWhiteSpace(txtTenSVDKO.Text)))
            {
                MessageBox.Show("Sinh Viên Này Đang Ở Trong Ký Túc Xá");
                return;
            }

            //them sv moi vo db
            SinhVien svnew = new SinhVien();

            svnew.Masv = dsdk[index].Masv;
            svnew.TenSV = dsdk[index].TenSV;
            svnew.NgaySinh = dsdk[index].NgaySinh;
            svnew.Lop = dsdk[index].Lop;
            svnew.GioiTinh = dsdk[index].GioiTinh;
            svnew.NgayVaoO = dsdk[index].NgayVaoO;
            svnew.SDT = dsdk[index].SDT;
            svnew.MK = dsdk[index].MK;
            svnew.email = dsdk[index].email;
            svnew.MaPhg = int.Parse(txtPhongDKChoSV.Text);

            db.SinhViens.Add(svnew);
            db.SaveChanges();

            //gui mail da dc duyet
            //taoj noi dung cho mail
            MailMessage message = new MailMessage("severnobita12345@gmail.com", txtEmailSVDKO.Text
                , "Đã Duyệt Dơn Đăng Ký Ở Ký Túc Xá", "Đơn ĐK của bạn đã được duyệt. " +
                "Bạn Hãy Thanh toán 2 tháng tiên phòng trước khi vào ở phòng " + txtPhongDKChoSV);

            //tao noi gui mail
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            //dang nhap gmail de gui
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("severnobita12345@gmail.com", "xmcy saty fpxr ovfq");



            try
            {
                client.Send(message);

                MessageBox.Show("Đã Gửi Mail Duyệt Cho Sinh Viên");
            }
            catch (Exception)
            {
                MessageBox.Show("Gửi Lỗi");
            }
        }

        //nut khong duyệt
        private void btnKhongDuyetSVDKO_Click(object sender, EventArgs e)
        {
            //gui mail lý do không dc duyet
            //tao noi dung cho mail
            MailMessage message = new MailMessage("severnobita12345@gmail.com", txtEmailSVDKO.Text
                ,"Đơn Đăng Ký Không Được Duyệt" ,txtLyDoKhongDuyet.Text);

            //tao noi gui mail
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            //dang nhap gmail de gui
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("severnobita12345@gmail.com", "xmcy saty fpxr ovfq");



            try
            {
                client.Send(message);

                MessageBox.Show("Đã Gửi Mail Duyệt Cho Sinh Viên");
            }
            catch (Exception)
            {
                MessageBox.Show("Gửi Lỗi");
            }
        }

//******************************************************************************************************
        //chuc nang thanh toan
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.FromArgb(224, 224, 224);
            btnDuyetDKO.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanlyPhong.BackColor = Color.FromArgb(224, 224, 224);
            btnThanhToan.BackColor = Color.Lime;
            btnQLTB.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanLyHoaDon.BackColor = Color.FromArgb(224, 224, 224);

            //chuyen hien thi chuc nang
            ChucNangQuanLy.Visible = false;
            ChucNangQLSV.Visible = false;
            ChucNangDKO.Visible = false;
            ChucNangThanhToan.Visible = true;
            ChucNangQLTB.Visible = false;
            ChucNangQLHoaDon.Visible = false;

            //hien thi danh sach hoa don len luoi
            dshoadon = db.HoaDons.Where(a=> (a.Phong.GiaTien - a.SoTienThanhToan) > 0).ToList();
            var x = from c in dshoadon
                    select new
                    {
                        c.MaHoaDon,
                        c.SinhVien.Masv,
                        c.SinhVien.TenSV,
                        Thang = c.NgayLapHD.ToString("MM-yyyy"),
                        TienNo = (c.SinhVien.NgayVaoO.Month == c.NgayLapHD.Month)?(c.Phong.GiaTien * 2).ToString()
                                     :c.Phong.GiaTien.ToString(),

                    };
            dataGridView1.DataSource = x.ToList();
        }

        // nut tim kieem sinh vien thanh toan
        private void btnTimKiemSVThanhToan_Click(object sender, EventArgs e)
        {

        }

        // nút thanh toán
        private void btnThanhToanTienKTX_Click(object sender, EventArgs e)
        {
            HoaDon hd = dshoadon[0];

            hd.SoTienThanhToan = int.Parse(txtSoTienThanhToan.Text);
            db.SaveChanges();
            MessageBox.Show("Thanh Toán Thành Công");
            dshoadon = db.HoaDons.Where(a => (a.Phong.GiaTien - a.SoTienThanhToan) > 0).ToList();
            var x = from c in dshoadon
                    select new
                    {
                        c.MaHoaDon,
                        c.SinhVien.Masv,
                        c.SinhVien.TenSV,
                        Thang = c.NgayLapHD.ToString("MM-yyyy"),
                        TienNo = (c.SinhVien.NgayVaoO.Month == c.NgayLapHD.Month) ? (c.Phong.GiaTien * 2).ToString()
                                     : c.Phong.GiaTien.ToString(),

                    };
            dataGridView1.DataSource = x.ToList();
        }

//******************************************************************************************************
        //chuc nang quan ly thiet bi
        private void btnQLTB_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.FromArgb(224, 224, 224);
            btnDuyetDKO.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanlyPhong.BackColor = Color.FromArgb(224, 224, 224);
            btnThanhToan.BackColor = Color.FromArgb(224, 224, 224);
            btnQLTB.BackColor = Color.Lime;
            btnQuanLyHoaDon.BackColor = Color.FromArgb(224, 224, 224);

            //chuyen hien thi chuc nang
            ChucNangQuanLy.Visible = false;
            ChucNangQLSV.Visible = false;
            ChucNangDKO.Visible = false;
            ChucNangThanhToan.Visible = false;
            ChucNangQLTB.Visible = true;
            ChucNangQLHoaDon.Visible = false;

            //hien thi du lieu len luoi
            dsPhg = db.Phongs.ToList();
            dsthietbi = dsPhg[0].ThietBis.ToList();
            ShowDSPhg(dsPhg, dtgvTBTrongPhg);
            var x = from a in dsthietbi
                    select new
                    {
                        a.MaTB,
                        a.TenTB
                    };
            dtgvThietBi.DataSource = x.ToList();
        }

        //cell click cho phong
        private void dtgvTBTrongPhg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > dtgvTBTrongPhg.Rows.Count || e.RowIndex < 0)
            { return; }

            //show len text
            txtMaPhgThietBi.Text = dsPhg[e.RowIndex].MaPhg.ToString();

            // show thong tin loai thiet bi len luoi
            dsthietbi = dsPhg[e.RowIndex].ThietBis.ToList();
            var x = from a in dsthietbi
                    select new
                    {
                        a.MaTB,
                        a.TenTB
                    };
            dtgvThietBi.DataSource = x.ToList();
        }

        //cell click cho thiet bi
        private void dtgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > dtgvTBTrongPhg.Rows.Count || e.RowIndex < 0)
            { return; }
            //show len text
            txtMaLoaiThietBi.Text = dsthietbi[e.RowIndex].MaTB.ToString();

            txtMaLTBThemXoa.Text = dsthietbi[e.RowIndex].MaTB.ToString();
            txtTenLTBThemXoa.Text = dsthietbi[e.RowIndex].TenTB.ToString();
        }
        //them thiet bị vo phong
        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            int maph = int.Parse(txtMaPhgThietBi.Text);
            int maloaitb = int.Parse(txtMaLoaiThietBi.Text);
            List<ThietBi> check = db.Phongs.Where(a => a.MaPhg == maph).ToList()[0].ThietBis.Where(c => c.MaTB == maloaitb).ToList();
            if(check.Count > 0)
            {
                MessageBox.Show("Đã Có Thiết Bị Này Trong Phòng");
                return;
            }                    
            // them vao db

            ThietBi tbnew = db.ThietBis.Where(a => a.MaTB == maloaitb).ToList()[0];
            Phong phgnew = db.Phongs.Where(a=> a.MaPhg == maph).ToList()[0];
            Phong update = db.Phongs.Where(a => a.MaPhg == maph).ToList()[0];
            update.GiaTien += 200000;
            db.Phongs.Where(a => a.MaPhg == maph).ToList()[0].ThietBis.Add(tbnew);
            db.ThietBis.Where(a=> a.MaTB == maloaitb).ToList()[0].Phongs.Add(phgnew);
            db.SaveChanges();
            //hien thi len luoi
            dsthietbi = dsPhg[0].ThietBis.ToList();
            ShowDSPhg(dsPhg, dtgvTBTrongPhg);
            var x = from a in dsthietbi
                    select new
                    {
                        a.MaTB,
                        a.TenTB
                    };
            dtgvThietBi.DataSource = x.ToList();
        }

        //bo thiet bi ra khoi phong
        private void btnXoaThietBi_Click(object sender, EventArgs e)
        {
            int maph = int.Parse(txtMaPhgThietBi.Text);
            int maloaitb = int.Parse(txtMaLoaiThietBi.Text);
            List<ThietBi> check = db.Phongs.Where(a => a.MaPhg == maph).ToList()[0].ThietBis.Where(c => c.MaTB == maloaitb).ToList();
            if (check.Count == 0)
            {
                MessageBox.Show("Không Có Thiết Bị Này Trong Phòng");
                return;
            }
           
            // xóa khoi db

            ThietBi tbremove = db.ThietBis.Where(a => a.MaTB == maloaitb).ToList()[0];
            Phong phgremove = db.Phongs.Where(a => a.MaPhg == maph).ToList()[0];
            Phong update = db.Phongs.Where(a => a.MaPhg == maph).ToList()[0];
            update.GiaTien -=200000 ;
            db.Phongs.Where(a => a.MaPhg == maph).ToList()[0].ThietBis.Remove(tbremove);
            db.ThietBis.Where(a => a.MaTB == maloaitb).ToList()[0].Phongs.Remove(phgremove);
            db.SaveChanges();
            //hien thi len luoi
            dsthietbi = dsPhg[0].ThietBis.ToList();
            ShowDSPhg(dsPhg, dtgvTBTrongPhg);
            var x = from a in dsthietbi
                    select new
                    {
                        a.MaTB,
                        a.TenTB
                    };
            dtgvThietBi.DataSource = x.ToList();
        }

        //them thiet bi vô db
        private void btnThemThietBiVaoKTX_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLTBThemXoa.Text) || string.IsNullOrWhiteSpace(txtMaLTBThemXoa.Text)
                || string.IsNullOrEmpty(txtTenLTBThemXoa.Text) || string.IsNullOrWhiteSpace(txtTenLTBThemXoa.Text))
            {
                MessageBox.Show("Chưa Nhập Thông Tin Hoặc Thiếu");
                return;
            }
            int matb = int.Parse(txtMaLTBThemXoa.Text);
            bool check = db.ThietBis.Any(a => a.MaTB == matb || a.TenTB == txtTenLTBThemXoa.Text);

            if(check == true)
            {
                MessageBox.Show("Mã Trùng Hoặc Đã Tồn Tại Loại Thiết Bị Này");
                return;
            }
            //them vao db
            ThietBi tb = new ThietBi();
            tb.MaTB = matb;
            tb.TenTB = txtTenLTBThemXoa.Text;
            db.ThietBis.Add(tb);
            db.SaveChanges();

            //hien thi toan bo len luoi

            dsthietbi = db.ThietBis.ToList();
            var x = from a in dsthietbi
                    select new
                    {
                        a.MaTB,
                        a.TenTB
                    };
            dtgvThietBi.DataSource = x.ToList();
        }

        //xoa thiet bi
        private void btnXoaThietBiKhoiKTX_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLTBThemXoa.Text) || string.IsNullOrWhiteSpace(txtMaLTBThemXoa.Text)
                || string.IsNullOrEmpty(txtTenLTBThemXoa.Text) || string.IsNullOrWhiteSpace(txtTenLTBThemXoa.Text))
            {
                MessageBox.Show("Chưa Nhập Thông Tin Hoặc Thiếu");
                return;
            }
            int matb = int.Parse(txtMaLTBThemXoa.Text);
            bool check = db.ThietBis.Any(a => a.MaTB == matb || a.TenTB == txtTenLTBThemXoa.Text);

            if (check == false)
            {
                MessageBox.Show("Không Có Loại Thiết Bị Này");
                return;
            }
            //Xóa vao db
            ThietBi tb = db.ThietBis.Where(a=> a.MaTB == matb).ToList()[0];

            foreach(Phong a in db.ThietBis.Where(a=> a.MaTB == matb).ToList()[0].Phongs)
            {
                a.GiaTien -= 200000;
                a.ThietBis.Remove(tb);
            }    

            db.ThietBis.Remove(tb);
            db.SaveChanges();

            //hien thi toan bo len luoi

            dsthietbi = db.ThietBis.ToList();
            var x = from a in dsthietbi
                    select new
                    {
                        a.MaTB,
                        a.TenTB
                    };
            dtgvThietBi.DataSource = x.ToList();
        }

        //hiện thị tất cả các loại thiết bị
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dsthietbi = db.ThietBis.ToList();
            var x = from a in dsthietbi
                    select new
                    {
                        a.MaTB,
                        a.TenTB
                    };
            dtgvThietBi.DataSource = x.ToList();
        }

//*******************************************************************************************************
        //quản lý hóa đơn
        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.FromArgb(224, 224, 224);
            btnDuyetDKO.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanlyPhong.BackColor = Color.FromArgb(224, 224, 224);
            btnThanhToan.BackColor = Color.FromArgb(224, 224, 224);
            btnQLTB.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanLyHoaDon.BackColor = Color.Lime;

            //chuyen hien thi chuc nang
            ChucNangQuanLy.Visible = false;
            ChucNangQLSV.Visible = false;
            ChucNangDKO.Visible = false;
            ChucNangThanhToan.Visible = false;
            ChucNangQLTB.Visible = false;
            ChucNangQLHoaDon.Visible = true;

            //hien thi thang thanh toan
            txtThangHoaDonDcTao.Text = DateTime.Now.ToString("MM-yyyy");

            
            //hien thi len combobox
            var x = from c in dshoadon
                    select new
                    {
                        ThangThanhToan = c.NgayLapHD.ToString("MM-yyyy"),
                    };
            cmbThangThanhToan.DataSource = x.ToList();
            cmbThangThanhToan.DisplayMember = "ThangThanhToan";

            if (dshoadon.Count == 0)
            {
                return;
            }
            //hien thi len luoi ds hoa don chua thanh toan
            dshoadon = db.HoaDons.Where(a=> (a.Phong.GiaTien - a.SoTienThanhToan) > 0 && a.NgayLapHD.ToString("MM-yyyy") == txtThangHoaDonDcTao.Text).ToList();
            ShowDSHD(dshoadon, dtgvHoaDon);
        }


        //hien thi hoa don chua thanh toan
        private void radChuaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            string thangthanhtoan = cmbThangThanhToan.SelectedItem.ToString();
            if (radChuaThanhToan.Checked)
            {
                dshoadon = db.HoaDons.Where(a => (a.Phong.GiaTien - a.SoTienThanhToan) > 0
                    && a.NgayLapHD.ToString("MM-yyyy") == thangthanhtoan).ToList();
                ShowDSHD(dshoadon, dtgvHoaDon);
            }
        }

        //hien thi danh sach da thanh toan
        private void radDaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            string thangthanhtoan = cmbThangThanhToan.SelectedItem.ToString();
            if (radDaThanhToan.Checked)
            {
                dshoadon = db.HoaDons.Where(a => (a.Phong.GiaTien - a.SoTienThanhToan) == 0
                    && a.NgayLapHD.ToString("MM-yyyy") == thangthanhtoan).ToList();
                ShowDSHD(dshoadon, dtgvHoaDon);
            }
        }

        private void cmbThangThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thangthanhtoan = cmbThangThanhToan.SelectedItem.ToString();

            dshoadon = db.HoaDons.Where(a => (a.Phong.GiaTien - a.SoTienThanhToan) == 0 
                && a.NgayLapHD.ToString("MM-yyyy") == thangthanhtoan).ToList();
            ShowDSHD(dshoadon, dtgvHoaDon);
        }



        //tao hoa dơn
        private void txtTaoHoaDon_Click(object sender, EventArgs e)
        {
            string maHD;
            bool check = false;
            Random rd = new Random();
            HoaDon hd = new HoaDon();
            for (int i = 0; i < db.SinhViens.ToList().Count; i++)
            {
                //tao ma tu dong va check trung
                do
                {
                    
                    maHD = DateTime.Now.ToString("hhmmss") + rd.Next(10, 99);

                    check = db.HoaDons.Any(a => a.MaHoaDon == maHD);
                    
                
                } while (check == true);
                hd.MaHoaDon = maHD;
                hd.NgayLapHD = DateTime.Now;
                hd.NgayThanhToan = null;
                hd.SoTienThanhToan = 0;
                hd.Masv = db.SinhViens.ToList()[i].Masv;
                hd.MaPhg = db.SinhViens.ToList()[i].Phong.MaPhg;

                dshoadon.Add(hd);
            }
            db.HoaDons.AddRange(dshoadon);
            db.SaveChanges();
            MessageBox.Show("tao thanh cong");
        }
    }
}
