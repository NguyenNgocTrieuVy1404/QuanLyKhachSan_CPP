﻿namespace QuanLyKhachSan
{
    partial class ThanhToan
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
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTongTienPhaiThanhToan = new System.Windows.Forms.Label();
            this.btnTimKiemTheoSDTKhachHang = new System.Windows.Forms.Button();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.btnXemDanhSachHoaDon = new System.Windows.Forms.Button();
            this.lblThongTinKhachHangThanhToan = new System.Windows.Forms.Label();
            this.dGVThanhToan = new System.Windows.Forms.DataGridView();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaTP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.lblTongTienTT = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblSoNgayO = new System.Windows.Forms.Label();
            this.lblNgayThanhT = new System.Windows.Forms.Label();
            this.lblKhach = new System.Windows.Forms.Label();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.cBHinhThuc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThanhToan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblThanhToan.Location = new System.Drawing.Point(372, 8);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(198, 31);
            this.lblThanhToan.TabIndex = 0;
            this.lblThanhToan.Text = "THANH TOÁN";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Location = new System.Drawing.Point(35, 77);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(101, 16);
            this.lblMaKhachHang.TabIndex = 2;
            this.lblMaKhachHang.Text = "Mã Khách Hàng:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(31, 129);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(105, 16);
            this.lblTenKhachHang.TabIndex = 5;
            this.lblTenKhachHang.Text = "Tên Khách Hàng:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(179, 121);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(234, 23);
            this.txtTenKhachHang.TabIndex = 6;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(35, 124);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(112, 16);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Ngày Thanh Toán:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(433, 86);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(73, 16);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Số Ngày Ở:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(438, 126);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(68, 16);
            this.lbl5.TabIndex = 12;
            this.lbl5.Text = "Mã Phòng:";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTinhTien.Location = new System.Drawing.Point(758, 550);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(119, 43);
            this.btnTinhTien.TabIndex = 13;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThoat.Location = new System.Drawing.Point(758, 626);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 43);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTongTienPhaiThanhToan
            // 
            this.lblTongTienPhaiThanhToan.AutoSize = true;
            this.lblTongTienPhaiThanhToan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienPhaiThanhToan.Location = new System.Drawing.Point(89, 179);
            this.lblTongTienPhaiThanhToan.Name = "lblTongTienPhaiThanhToan";
            this.lblTongTienPhaiThanhToan.Size = new System.Drawing.Size(194, 17);
            this.lblTongTienPhaiThanhToan.TabIndex = 16;
            this.lblTongTienPhaiThanhToan.Text = "Tổng Tiền Phải Thanh Toán:";
            // 
            // btnTimKiemTheoSDTKhachHang
            // 
            this.btnTimKiemTheoSDTKhachHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimKiemTheoSDTKhachHang.Location = new System.Drawing.Point(556, 163);
            this.btnTimKiemTheoSDTKhachHang.Name = "btnTimKiemTheoSDTKhachHang";
            this.btnTimKiemTheoSDTKhachHang.Size = new System.Drawing.Size(135, 44);
            this.btnTimKiemTheoSDTKhachHang.TabIndex = 18;
            this.btnTimKiemTheoSDTKhachHang.Text = "Tìm Kiếm ";
            this.btnTimKiemTheoSDTKhachHang.UseVisualStyleBackColor = false;
            this.btnTimKiemTheoSDTKhachHang.Click += new System.EventHandler(this.btnTimKiemTheoSDTKhachHang_Click);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Location = new System.Drawing.Point(82, 736);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(79, 16);
            this.lblMaHoaDon.TabIndex = 19;
            this.lblMaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.Location = new System.Drawing.Point(196, 734);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(234, 23);
            this.txtMaHoaDon.TabIndex = 20;
            // 
            // btnXemDanhSachHoaDon
            // 
            this.btnXemDanhSachHoaDon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXemDanhSachHoaDon.Location = new System.Drawing.Point(644, 736);
            this.btnXemDanhSachHoaDon.Name = "btnXemDanhSachHoaDon";
            this.btnXemDanhSachHoaDon.Size = new System.Drawing.Size(233, 47);
            this.btnXemDanhSachHoaDon.TabIndex = 22;
            this.btnXemDanhSachHoaDon.Text = "Xem Danh Sách Hóa Đơn";
            this.btnXemDanhSachHoaDon.UseVisualStyleBackColor = false;
            this.btnXemDanhSachHoaDon.Click += new System.EventHandler(this.btnXemDanhSachHoaDon_Click);
            // 
            // lblThongTinKhachHangThanhToan
            // 
            this.lblThongTinKhachHangThanhToan.AutoSize = true;
            this.lblThongTinKhachHangThanhToan.Location = new System.Drawing.Point(35, 235);
            this.lblThongTinKhachHangThanhToan.Name = "lblThongTinKhachHangThanhToan";
            this.lblThongTinKhachHangThanhToan.Size = new System.Drawing.Size(212, 16);
            this.lblThongTinKhachHangThanhToan.TabIndex = 23;
            this.lblThongTinKhachHangThanhToan.Text = "Thông Tin Khách Hàng Thanh Toán";
            // 
            // dGVThanhToan
            // 
            this.dGVThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVThanhToan.Location = new System.Drawing.Point(39, 260);
            this.dGVThanhToan.Name = "dGVThanhToan";
            this.dGVThanhToan.RowHeadersWidth = 51;
            this.dGVThanhToan.RowTemplate.Height = 24;
            this.dGVThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVThanhToan.Size = new System.Drawing.Size(838, 179);
            this.dGVThanhToan.TabIndex = 24;
            this.dGVThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVThanhToan_CellContentClick);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(179, 72);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(234, 23);
            this.txtMaKhachHang.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tìm Kiếm Theo SDT Khách Hàng:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReset.Location = new System.Drawing.Point(758, 476);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 44);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaTP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Controls.Add(this.lblTongTienTT);
            this.groupBox1.Controls.Add(this.lblMaPhong);
            this.groupBox1.Controls.Add(this.lblSoNgayO);
            this.groupBox1.Controls.Add(this.lblNgayThanhT);
            this.groupBox1.Controls.Add(this.lblKhach);
            this.groupBox1.Controls.Add(this.lblMaKhach);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lblTongTienPhaiThanhToan);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Location = new System.Drawing.Point(39, 463);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(695, 227);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Toán";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblMaTP
            // 
            this.lblMaTP.AutoSize = true;
            this.lblMaTP.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTP.Location = new System.Drawing.Point(545, 39);
            this.lblMaTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaTP.Name = "lblMaTP";
            this.lblMaTP.Size = new System.Drawing.Size(40, 17);
            this.lblMaTP.TabIndex = 30;
            this.lblMaTP.Text = "........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã Thuê Phòng:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.ForeColor = System.Drawing.Color.Blue;
            this.txtTongtien.Location = new System.Drawing.Point(335, 170);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(234, 35);
            this.txtTongtien.TabIndex = 27;
            this.txtTongtien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTongTienTT
            // 
            this.lblTongTienTT.AutoSize = true;
            this.lblTongTienTT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienTT.Location = new System.Drawing.Point(392, 170);
            this.lblTongTienTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTienTT.Name = "lblTongTienTT";
            this.lblTongTienTT.Size = new System.Drawing.Size(0, 17);
            this.lblTongTienTT.TabIndex = 22;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(545, 129);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(40, 17);
            this.lblMaPhong.TabIndex = 21;
            this.lblMaPhong.Text = "........";
            // 
            // lblSoNgayO
            // 
            this.lblSoNgayO.AutoSize = true;
            this.lblSoNgayO.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayO.Location = new System.Drawing.Point(545, 87);
            this.lblSoNgayO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoNgayO.Name = "lblSoNgayO";
            this.lblSoNgayO.Size = new System.Drawing.Size(40, 17);
            this.lblSoNgayO.TabIndex = 20;
            this.lblSoNgayO.Text = "........";
            // 
            // lblNgayThanhT
            // 
            this.lblNgayThanhT.AutoSize = true;
            this.lblNgayThanhT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThanhT.Location = new System.Drawing.Point(199, 124);
            this.lblNgayThanhT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayThanhT.Name = "lblNgayThanhT";
            this.lblNgayThanhT.Size = new System.Drawing.Size(40, 17);
            this.lblNgayThanhT.TabIndex = 19;
            this.lblNgayThanhT.Text = "........";
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhach.Location = new System.Drawing.Point(199, 84);
            this.lblKhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(40, 17);
            this.lblKhach.TabIndex = 18;
            this.lblKhach.Text = "........";
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.AutoSize = true;
            this.lblMaKhach.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhach.Location = new System.Drawing.Point(199, 42);
            this.lblMaKhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(40, 17);
            this.lblMaKhach.TabIndex = 17;
            this.lblMaKhach.Text = "........";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(68, 84);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(79, 16);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Khách Hàng:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(46, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 16);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Mã Khách Hàng:";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInHoaDon.Location = new System.Drawing.Point(458, 770);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(169, 47);
            this.btnInHoaDon.TabIndex = 30;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 779);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hình Thức";
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThemHoaDon.Location = new System.Drawing.Point(458, 717);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(169, 47);
            this.btnThemHoaDon.TabIndex = 33;
            this.btnThemHoaDon.Text = "Thêm Hóa Đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = false;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(283, 175);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(234, 23);
            this.txtSDTKH.TabIndex = 34;
            // 
            // cBHinhThuc
            // 
            this.cBHinhThuc.FormattingEnabled = true;
            this.cBHinhThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản ",
            "Thẻ ATM",
            "Thẻ thành viên"});
            this.cBHinhThuc.Location = new System.Drawing.Point(196, 779);
            this.cBHinhThuc.Name = "cBHinhThuc";
            this.cBHinhThuc.Size = new System.Drawing.Size(235, 23);
            this.cBHinhThuc.TabIndex = 35;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 836);
            this.Controls.Add(this.cBHinhThuc);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.btnThemHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.dGVThanhToan);
            this.Controls.Add(this.lblThongTinKhachHangThanhToan);
            this.Controls.Add(this.btnXemDanhSachHoaDon);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.btnTimKiemTheoSDTKhachHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblMaKhachHang);
            this.Controls.Add(this.lblThanhToan);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThanhToan";
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVThanhToan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTongTienPhaiThanhToan;
        private System.Windows.Forms.Button btnTimKiemTheoSDTKhachHang;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Button btnXemDanhSachHoaDon;
        private System.Windows.Forms.Label lblThongTinKhachHangThanhToan;
        private System.Windows.Forms.DataGridView dGVThanhToan;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSoNgayO;
        private System.Windows.Forms.Label lblNgayThanhT;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTongTienTT;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaTP;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.ComboBox cBHinhThuc;
    }
}