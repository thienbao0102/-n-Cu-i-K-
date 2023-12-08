using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKyLTHDT
{
    public partial class GiaoDienQuanLy : Form
    {

        DoAnCuoiKyLTHDTEntities2 db = new DoAnCuoiKyLTHDTEntities2 ();
        List<Phong> dsPhg = new List<Phong>();
        List<SinhVien> dssv = new List<SinhVien>();
        public GiaoDienQuanLy()
        {
            InitializeComponent();
        }

        private void GiaoDienQuanLy_Load(object sender, EventArgs e)
        {
            //hiện thị danh sách phòng lên lưới
            dsPhg = db.Phongs.ToList();
            ShowDSPhg(dsPhg);

            //hiện thị thong tin phòng đầu tiên lên lưới
            txtMaPhg.Text = dsPhg[0].MaPhg.ToString();
            txtGiaTien.Text = dsPhg[0].GiaTien.ToString();
            txtSoGiuong.Text = dsPhg[0].SoGiuong + "";
            txtSoNguoi.Text = dsPhg[0].SinhViens.Count + "";
            txtLoaiPhg.Text = dsPhg[0].LoaiPhg;

            //hiện thị danh sách thông tin sinh vien ở phòng đầu
            dssv = dsPhg[0].SinhViens.ToList();
            ShowDSSV(dssv);
        }

        private void ShowDSPhg(List<Phong> dsPhg)
        {
            dtgvPhg.DataSource = dsPhg;
            dtgvPhg.Columns[4].Width = 0;
            dtgvPhg.Columns[4].Visible = false;
            dtgvPhg.Columns[5].Width = 0;
            dtgvPhg.Columns[5].Visible = false;
            dtgvPhg.Columns[6].Width = 0;
            dtgvPhg.Columns[6].Visible = false;
            dtgvPhg.Columns[0].Width = 194;
            dtgvPhg.Columns[1].Width = 194;
            dtgvPhg.Columns[2].Width = 194;
            dtgvPhg.Columns[3].Width = 194;
        }

        private void ShowDSSV(List<SinhVien> dssv)
        {
            dtgvSVTrongPhg.DataSource = dssv;
            dtgvSVTrongPhg.Columns[8].Width = 0;
            dtgvSVTrongPhg.Columns[8].Visible = false;
            dtgvSVTrongPhg.Columns[9].Width = 0;
            dtgvSVTrongPhg.Columns[9].Visible = false;
            dtgvSVTrongPhg.Columns[10].Width = 0;
            dtgvSVTrongPhg.Columns[10].Visible = false;
            dtgvSVTrongPhg.Columns[11].Width = 0;
            dtgvSVTrongPhg.Columns[11].Visible = false;
            dtgvSVTrongPhg.Columns[12].Width = 0;
            dtgvSVTrongPhg.Columns[12].Visible = false;

        }

        private void dtgvPhg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > dtgvPhg.Rows.Count)
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
            ShowDSSV(dssv);
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
            ShowDSPhg(dsPhg);
            ShowDSSV(dssv);
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.Lime;
            btnDuyetDKO.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanlyPhong.BackColor = Color.FromArgb(224, 224, 224);
            btnThanhToan.BackColor = Color.FromArgb(224, 224, 224);
            btnQLTB.BackColor = Color.FromArgb(224,224,224);

            //chuyen hien thi chuc nang
            ChucNangQuanLy.Visible = false;
        }

        private void btnQuanlyPhong_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.FromArgb(224, 224, 224);
            btnDuyetDKO.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanlyPhong.BackColor = Color.Lime;
            btnThanhToan.BackColor = Color.FromArgb(224, 224, 224);
            btnQLTB.BackColor = Color.FromArgb(224, 224, 224);

            //chuyen hien thi chuc nang
            ChucNangQuanLy.Visible = true;
        }

        private void btnDuyetDKO_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.FromArgb(224, 224, 224);
            btnDuyetDKO.BackColor = Color.Lime;
            btnQuanlyPhong.BackColor = Color.FromArgb(224, 224, 224);
            btnThanhToan.BackColor = Color.FromArgb(224, 224, 224);
            btnQLTB.BackColor = Color.FromArgb(224, 224, 224);
            //chuyen hien thi chuc nang
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.FromArgb(224, 224, 224);
            btnDuyetDKO.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanlyPhong.BackColor = Color.FromArgb(224, 224, 224);
            btnThanhToan.BackColor = Color.Lime;
            btnQLTB.BackColor = Color.FromArgb(224, 224, 224);

            //chuyen hien thi chuc nang
        }

        private void btnQLTB_Click(object sender, EventArgs e)
        {
            //doi mau button khi click
            btnQLSV.BackColor = Color.FromArgb(224, 224, 224);
            btnDuyetDKO.BackColor = Color.FromArgb(224, 224, 224);
            btnQuanlyPhong.BackColor = Color.FromArgb(224, 224, 224);
            btnThanhToan.BackColor = Color.FromArgb(224, 224, 224);
            btnQLTB.BackColor = Color.Lime;

            //chuyen hien thi chuc nang
        }
    }
}
