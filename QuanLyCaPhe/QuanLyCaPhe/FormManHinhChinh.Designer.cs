namespace QuanLyCaPhe
{
    partial class FormManHinhChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManHinhChinh));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.QL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThanhPho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHuongDanSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTinUngDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.flpnlBanAn = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.nudgiamgia = new System.Windows.Forms.NumericUpDown();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.cmbmonan = new System.Windows.Forms.ComboBox();
            this.cmbdanhmucmonan = new System.Windows.Forms.ComboBox();
            this.nudThemmon = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudgiamgia)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThemmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.QL,
            this.trợGiúpToolStripMenuItem,
            this.menuAdmin});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1342, 33);
            this.menuStrip.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangNhap,
            this.toolStripSeparator1,
            this.menuThoat});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 29);
            this.toolStripMenuItem1.Text = "Hệ thống";
            // 
            // menuDangNhap
            // 
            this.menuDangNhap.Name = "menuDangNhap";
            this.menuDangNhap.Size = new System.Drawing.Size(268, 34);
            this.menuDangNhap.Text = "Đăng nhập  Alt + X";
            this.menuDangNhap.Click += new System.EventHandler(this.menuDangNhap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // menuThoat
            // 
            this.menuThoat.Enabled = false;
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(268, 34);
            this.menuThoat.Text = "Thoát           Alt + Z";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // QL
            // 
            this.QL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanVien,
            this.menuThanhPho,
            this.menuHoaDon,
            this.menuKhachHang});
            this.QL.Name = "QL";
            this.QL.Size = new System.Drawing.Size(89, 29);
            this.QL.Text = "Quản lý";
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(278, 34);
            this.menuNhanVien.Text = "Quản lý nhân viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // menuThanhPho
            // 
            this.menuThanhPho.Name = "menuThanhPho";
            this.menuThanhPho.Size = new System.Drawing.Size(278, 34);
            this.menuThanhPho.Text = "Quản lý thành phố";
            this.menuThanhPho.Click += new System.EventHandler(this.menuThanhPho_Click);
            // 
            // menuHoaDon
            // 
            this.menuHoaDon.Name = "menuHoaDon";
            this.menuHoaDon.Size = new System.Drawing.Size(278, 34);
            this.menuHoaDon.Text = "Quản lý hóa đơn";
            this.menuHoaDon.Click += new System.EventHandler(this.menuHoaDon_Click);
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Size = new System.Drawing.Size(278, 34);
            this.menuKhachHang.Text = "Quản Lý Khách Hàng";
            this.menuKhachHang.Click += new System.EventHandler(this.menuKhachHang_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHuongDanSuDung,
            this.menuThongTinUngDung});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // menuHuongDanSuDung
            // 
            this.menuHuongDanSuDung.Name = "menuHuongDanSuDung";
            this.menuHuongDanSuDung.Size = new System.Drawing.Size(276, 34);
            this.menuHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            this.menuHuongDanSuDung.Click += new System.EventHandler(this.menuHuongDanSuDung_Click);
            // 
            // menuThongTinUngDung
            // 
            this.menuThongTinUngDung.Name = "menuThongTinUngDung";
            this.menuThongTinUngDung.Size = new System.Drawing.Size(276, 34);
            this.menuThongTinUngDung.Text = "Thông tin ứng dụng";
            this.menuThongTinUngDung.Click += new System.EventHandler(this.menuThongTinUngDung_Click);
            // 
            // menuAdmin
            // 
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(137, 29);
            this.menuAdmin.Text = "Administrator";
            this.menuAdmin.Visible = false;
            this.menuAdmin.Click += new System.EventHandler(this.menuAdmin_Click);
            // 
            // flpnlBanAn
            // 
            this.flpnlBanAn.AutoScroll = true;
            this.flpnlBanAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpnlBanAn.Location = new System.Drawing.Point(0, 49);
            this.flpnlBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpnlBanAn.Name = "flpnlBanAn";
            this.flpnlBanAn.Size = new System.Drawing.Size(700, 613);
            this.flpnlBanAn.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvhoadon);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(698, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 617);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTongtien);
            this.panel3.Controls.Add(this.nudgiamgia);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(3, 528);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 80);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng Tiền";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongtien.Location = new System.Drawing.Point(304, 37);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTongtien.Size = new System.Drawing.Size(152, 35);
            this.txtTongtien.TabIndex = 0;
            this.txtTongtien.Text = "0";
            // 
            // nudgiamgia
            // 
            this.nudgiamgia.Location = new System.Drawing.Point(164, 45);
            this.nudgiamgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudgiamgia.Name = "nudgiamgia";
            this.nudgiamgia.Size = new System.Drawing.Size(110, 26);
            this.nudgiamgia.TabIndex = 2;
            this.nudgiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Location = new System.Drawing.Point(160, 5);
            this.btnGiamGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(112, 35);
            this.btnGiamGia.TabIndex = 1;
            this.btnGiamGia.Text = "Giảm Giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            this.btnGiamGia.Click += new System.EventHandler(this.btnGiamGia_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(492, 2);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(108, 78);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoaMon);
            this.panel2.Controls.Add(this.cmbmonan);
            this.panel2.Controls.Add(this.cmbdanhmucmonan);
            this.panel2.Controls.Add(this.nudThemmon);
            this.panel2.Controls.Add(this.btnThemMon);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 78);
            this.panel2.TabIndex = 0;
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(408, 0);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(106, 77);
            this.btnXoaMon.TabIndex = 5;
            this.btnXoaMon.Text = "Xóa Món";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // cmbmonan
            // 
            this.cmbmonan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmonan.FormattingEnabled = true;
            this.cmbmonan.Location = new System.Drawing.Point(8, 46);
            this.cmbmonan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbmonan.Name = "cmbmonan";
            this.cmbmonan.Size = new System.Drawing.Size(240, 28);
            this.cmbmonan.TabIndex = 4;
            // 
            // cmbdanhmucmonan
            // 
            this.cmbdanhmucmonan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdanhmucmonan.FormattingEnabled = true;
            this.cmbdanhmucmonan.Location = new System.Drawing.Point(8, 5);
            this.cmbdanhmucmonan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbdanhmucmonan.Name = "cmbdanhmucmonan";
            this.cmbdanhmucmonan.Size = new System.Drawing.Size(240, 28);
            this.cmbdanhmucmonan.TabIndex = 3;
            this.cmbdanhmucmonan.SelectedIndexChanged += new System.EventHandler(this.cmbdanhmucmonan_SelectedIndexChanged);
            // 
            // nudThemmon
            // 
            this.nudThemmon.Location = new System.Drawing.Point(534, 28);
            this.nudThemmon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudThemmon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudThemmon.Name = "nudThemmon";
            this.nudThemmon.Size = new System.Drawing.Size(66, 26);
            this.nudThemmon.TabIndex = 2;
            this.nudThemmon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudThemmon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(276, 0);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(106, 77);
            this.btnThemMon.TabIndex = 1;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.SoLuong,
            this.Gia,
            this.Column1});
            this.dgvhoadon.Location = new System.Drawing.Point(0, 92);
            this.dgvhoadon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.RowHeadersWidth = 62;
            this.dgvhoadon.Size = new System.Drawing.Size(645, 426);
            this.dgvhoadon.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenThucAn";
            this.Column2.HeaderText = "Tên Thức Ăn";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 50;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Đơn Giá";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            this.Gia.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Thành Tiền";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // FormManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpnlBanAn);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cà Phê ( Màn Hình Chính)";
            this.Load += new System.EventHandler(this.FormManHinhChinh_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudgiamgia)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudThemmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDangNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuHuongDanSuDung;
        private System.Windows.Forms.ToolStripMenuItem menuThongTinUngDung;
        private System.Windows.Forms.FlowLayoutPanel flpnlBanAn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudgiamgia;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudThemmon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cmbmonan;
        private System.Windows.Forms.ComboBox cmbdanhmucmonan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripMenuItem QL;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuThanhPho;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHang;
    }
}