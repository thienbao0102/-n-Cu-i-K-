namespace DoAnCuoiKyLTHDT
{
    partial class GiaoDienQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienQuanLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDuyetDKO = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.btnQuanlyPhong = new System.Windows.Forms.Button();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Panel();
            this.ChucNangQuanLy = new System.Windows.Forms.Panel();
            this.txtThongTinTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtLoaiPhg = new System.Windows.Forms.TextBox();
            this.txtSoGiuong = new System.Windows.Forms.TextBox();
            this.txtMaPhg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvSVTrongPhg = new System.Windows.Forms.DataGridView();
            this.dtgvPhg = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnQLTB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ChucNangQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSVTrongPhg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnQLTB);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnDuyetDKO);
            this.panel1.Controls.Add(this.btnQLSV);
            this.panel1.Controls.Add(this.btnQuanlyPhong);
            this.panel1.Controls.Add(this.lblNameUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.User);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 651);
            this.panel1.TabIndex = 0;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Location = new System.Drawing.Point(11, 261);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(185, 30);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh Toán\r\n\r\n\r\n";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDuyetDKO
            // 
            this.btnDuyetDKO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDuyetDKO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuyetDKO.Location = new System.Drawing.Point(11, 215);
            this.btnDuyetDKO.Name = "btnDuyetDKO";
            this.btnDuyetDKO.Size = new System.Drawing.Size(185, 30);
            this.btnDuyetDKO.TabIndex = 6;
            this.btnDuyetDKO.Text = "Duyệt Đăng Ký Ở";
            this.btnDuyetDKO.UseVisualStyleBackColor = false;
            this.btnDuyetDKO.Click += new System.EventHandler(this.btnDuyetDKO_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQLSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQLSV.Location = new System.Drawing.Point(11, 169);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(185, 30);
            this.btnQLSV.TabIndex = 5;
            this.btnQLSV.Text = "Quản Lý Sinh Viên\r\n\r\n\r\n";
            this.btnQLSV.UseVisualStyleBackColor = false;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnQuanlyPhong
            // 
            this.btnQuanlyPhong.BackColor = System.Drawing.Color.Lime;
            this.btnQuanlyPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanlyPhong.Location = new System.Drawing.Point(11, 116);
            this.btnQuanlyPhong.Name = "btnQuanlyPhong";
            this.btnQuanlyPhong.Size = new System.Drawing.Size(185, 30);
            this.btnQuanlyPhong.TabIndex = 4;
            this.btnQuanlyPhong.Text = "Quản Lý Phòng\r\n";
            this.btnQuanlyPhong.UseVisualStyleBackColor = false;
            this.btnQuanlyPhong.Click += new System.EventHandler(this.btnQuanlyPhong_Click);
            // 
            // lblNameUser
            // 
            this.lblNameUser.Location = new System.Drawing.Point(0, 67);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(215, 23);
            this.lblNameUser.TabIndex = 3;
            this.lblNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "_______________________________";
            // 
            // User
            // 
            this.User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User.BackgroundImage")));
            this.User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.User.Location = new System.Drawing.Point(76, 11);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(50, 50);
            this.User.TabIndex = 2;
            // 
            // ChucNangQuanLy
            // 
            this.ChucNangQuanLy.Controls.Add(this.btnTimKiem);
            this.ChucNangQuanLy.Controls.Add(this.txtThongTinTimKiem);
            this.ChucNangQuanLy.Controls.Add(this.label7);
            this.ChucNangQuanLy.Controls.Add(this.txtSoNguoi);
            this.ChucNangQuanLy.Controls.Add(this.txtGiaTien);
            this.ChucNangQuanLy.Controls.Add(this.txtLoaiPhg);
            this.ChucNangQuanLy.Controls.Add(this.txtSoGiuong);
            this.ChucNangQuanLy.Controls.Add(this.txtMaPhg);
            this.ChucNangQuanLy.Controls.Add(this.label6);
            this.ChucNangQuanLy.Controls.Add(this.label5);
            this.ChucNangQuanLy.Controls.Add(this.label4);
            this.ChucNangQuanLy.Controls.Add(this.label3);
            this.ChucNangQuanLy.Controls.Add(this.label2);
            this.ChucNangQuanLy.Controls.Add(this.dtgvSVTrongPhg);
            this.ChucNangQuanLy.Controls.Add(this.dtgvPhg);
            this.ChucNangQuanLy.Location = new System.Drawing.Point(225, 1);
            this.ChucNangQuanLy.Name = "ChucNangQuanLy";
            this.ChucNangQuanLy.Size = new System.Drawing.Size(859, 651);
            this.ChucNangQuanLy.TabIndex = 1;
            // 
            // txtThongTinTimKiem
            // 
            this.txtThongTinTimKiem.Location = new System.Drawing.Point(148, 110);
            this.txtThongTinTimKiem.Name = "txtThongTinTimKiem";
            this.txtThongTinTimKiem.Size = new System.Drawing.Size(191, 25);
            this.txtThongTinTimKiem.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thông Tin tìm Kiếm";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(605, 13);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(150, 25);
            this.txtSoNguoi.TabIndex = 11;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(334, 49);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(147, 25);
            this.txtGiaTien.TabIndex = 10;
            // 
            // txtLoaiPhg
            // 
            this.txtLoaiPhg.Location = new System.Drawing.Point(334, 13);
            this.txtLoaiPhg.Name = "txtLoaiPhg";
            this.txtLoaiPhg.Size = new System.Drawing.Size(147, 25);
            this.txtLoaiPhg.TabIndex = 9;
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.Location = new System.Drawing.Point(90, 49);
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.Size = new System.Drawing.Size(137, 25);
            this.txtSoGiuong.TabIndex = 8;
            // 
            // txtMaPhg
            // 
            this.txtMaPhg.Location = new System.Drawing.Point(90, 13);
            this.txtMaPhg.Name = "txtMaPhg";
            this.txtMaPhg.Size = new System.Drawing.Size(137, 25);
            this.txtMaPhg.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giá Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Người Ở";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Giường";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Phòng";
            // 
            // dtgvSVTrongPhg
            // 
            this.dtgvSVTrongPhg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSVTrongPhg.Location = new System.Drawing.Point(14, 496);
            this.dtgvSVTrongPhg.Name = "dtgvSVTrongPhg";
            this.dtgvSVTrongPhg.RowHeadersWidth = 51;
            this.dtgvSVTrongPhg.RowTemplate.Height = 24;
            this.dtgvSVTrongPhg.Size = new System.Drawing.Size(831, 144);
            this.dtgvSVTrongPhg.TabIndex = 1;
            // 
            // dtgvPhg
            // 
            this.dtgvPhg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhg.Location = new System.Drawing.Point(14, 169);
            this.dtgvPhg.Name = "dtgvPhg";
            this.dtgvPhg.RowHeadersWidth = 51;
            this.dtgvPhg.RowTemplate.Height = 24;
            this.dtgvPhg.Size = new System.Drawing.Size(831, 321);
            this.dtgvPhg.TabIndex = 0;
            this.dtgvPhg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhg_CellClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Blue;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(379, 107);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnQLTB
            // 
            this.btnQLTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQLTB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQLTB.Location = new System.Drawing.Point(11, 308);
            this.btnQLTB.Name = "btnQLTB";
            this.btnQLTB.Size = new System.Drawing.Size(185, 30);
            this.btnQLTB.TabIndex = 8;
            this.btnQLTB.Text = "Quản Lý Thiết Bị";
            this.btnQLTB.UseVisualStyleBackColor = false;
            this.btnQLTB.Click += new System.EventHandler(this.btnQLTB_Click);
            // 
            // GiaoDienQuanLy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.ChucNangQuanLy);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "GiaoDienQuanLy";
            this.Text = "GiaoDienQuanLy";
            this.Load += new System.EventHandler(this.GiaoDienQuanLy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ChucNangQuanLy.ResumeLayout(false);
            this.ChucNangQuanLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSVTrongPhg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel User;
        private System.Windows.Forms.Button btnQuanlyPhong;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDuyetDKO;
        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Panel ChucNangQuanLy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvSVTrongPhg;
        private System.Windows.Forms.DataGridView dtgvPhg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtLoaiPhg;
        private System.Windows.Forms.TextBox txtSoGiuong;
        private System.Windows.Forms.TextBox txtMaPhg;
        private System.Windows.Forms.TextBox txtThongTinTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnQLTB;
    }
}