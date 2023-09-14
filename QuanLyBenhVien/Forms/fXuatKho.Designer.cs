namespace QuanLyBenhVien.Forms
{
    partial class fXuatKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btInPhieuXuat = new System.Windows.Forms.Button();
            this.tbMaNhanVien = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btTaoPhieuXuat = new System.Windows.Forms.Button();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.lbDienMaPhieu = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbNhanVienLapPhieu = new System.Windows.Forms.Label();
            this.lbNgayNhapPhieu = new System.Windows.Forms.Label();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.lbThongTinPhieuXuat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachPhieuXuat = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvChiTietPhieuXuat = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaThuoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuXuat)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btInPhieuXuat);
            this.panel1.Controls.Add(this.tbMaNhanVien);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btTaoPhieuXuat);
            this.panel1.Controls.Add(this.tbGhiChu);
            this.panel1.Controls.Add(this.dtpNgayLapPhieu);
            this.panel1.Controls.Add(this.lbDienMaPhieu);
            this.panel1.Controls.Add(this.lbGhiChu);
            this.panel1.Controls.Add(this.lbNhanVienLapPhieu);
            this.panel1.Controls.Add(this.lbNgayNhapPhieu);
            this.panel1.Controls.Add(this.lbMaPhieu);
            this.panel1.Controls.Add(this.lbThongTinPhieuXuat);
            this.panel1.Location = new System.Drawing.Point(726, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 236);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btInPhieuXuat
            // 
            this.btInPhieuXuat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInPhieuXuat.Location = new System.Drawing.Point(412, 186);
            this.btInPhieuXuat.Name = "btInPhieuXuat";
            this.btInPhieuXuat.Size = new System.Drawing.Size(165, 37);
            this.btInPhieuXuat.TabIndex = 10;
            this.btInPhieuXuat.Text = "Xuất Thuốc";
            this.btInPhieuXuat.UseVisualStyleBackColor = true;
            this.btInPhieuXuat.Click += new System.EventHandler(this.btInPhieuXuat_Click);
            // 
            // tbMaNhanVien
            // 
            this.tbMaNhanVien.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNhanVien.Location = new System.Drawing.Point(159, 75);
            this.tbMaNhanVien.Name = "tbMaNhanVien";
            this.tbMaNhanVien.Size = new System.Drawing.Size(466, 28);
            this.tbMaNhanVien.TabIndex = 21;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(235, 187);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(153, 36);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa Phiếu";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btTaoPhieuXuat
            // 
            this.btTaoPhieuXuat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoPhieuXuat.Location = new System.Drawing.Point(53, 187);
            this.btTaoPhieuXuat.Name = "btTaoPhieuXuat";
            this.btTaoPhieuXuat.Size = new System.Drawing.Size(141, 36);
            this.btTaoPhieuXuat.TabIndex = 9;
            this.btTaoPhieuXuat.Text = "Tạo Phiếu Xuất";
            this.btTaoPhieuXuat.UseVisualStyleBackColor = true;
            this.btTaoPhieuXuat.Click += new System.EventHandler(this.btTaoPhieuXuat_Click);
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGhiChu.Location = new System.Drawing.Point(158, 144);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(467, 28);
            this.tbGhiChu.TabIndex = 16;
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLapPhieu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(159, 109);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(466, 28);
            this.dtpNgayLapPhieu.TabIndex = 14;
            // 
            // lbDienMaPhieu
            // 
            this.lbDienMaPhieu.AutoSize = true;
            this.lbDienMaPhieu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienMaPhieu.Location = new System.Drawing.Point(154, 42);
            this.lbDienMaPhieu.Name = "lbDienMaPhieu";
            this.lbDienMaPhieu.Size = new System.Drawing.Size(100, 21);
            this.lbDienMaPhieu.TabIndex = 11;
            this.lbDienMaPhieu.Text = "__________";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhiChu.Location = new System.Drawing.Point(20, 147);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(67, 21);
            this.lbGhiChu.TabIndex = 7;
            this.lbGhiChu.Text = "Ghi Chú";
            // 
            // lbNhanVienLapPhieu
            // 
            this.lbNhanVienLapPhieu.AutoSize = true;
            this.lbNhanVienLapPhieu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVienLapPhieu.Location = new System.Drawing.Point(20, 75);
            this.lbNhanVienLapPhieu.Name = "lbNhanVienLapPhieu";
            this.lbNhanVienLapPhieu.Size = new System.Drawing.Size(103, 21);
            this.lbNhanVienLapPhieu.TabIndex = 6;
            this.lbNhanVienLapPhieu.Text = "NV lập phiếu";
            // 
            // lbNgayNhapPhieu
            // 
            this.lbNgayNhapPhieu.AutoSize = true;
            this.lbNgayNhapPhieu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayNhapPhieu.Location = new System.Drawing.Point(19, 111);
            this.lbNgayNhapPhieu.Name = "lbNgayNhapPhieu";
            this.lbNgayNhapPhieu.Size = new System.Drawing.Size(119, 21);
            this.lbNgayNhapPhieu.TabIndex = 5;
            this.lbNgayNhapPhieu.Text = "Ngày lập phiếu";
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.AutoSize = true;
            this.lbMaPhieu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieu.Location = new System.Drawing.Point(20, 42);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(77, 21);
            this.lbMaPhieu.TabIndex = 3;
            this.lbMaPhieu.Text = "Mã phiếu";
            // 
            // lbThongTinPhieuXuat
            // 
            this.lbThongTinPhieuXuat.AutoSize = true;
            this.lbThongTinPhieuXuat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinPhieuXuat.Location = new System.Drawing.Point(3, 9);
            this.lbThongTinPhieuXuat.Name = "lbThongTinPhieuXuat";
            this.lbThongTinPhieuXuat.Size = new System.Drawing.Size(220, 21);
            this.lbThongTinPhieuXuat.TabIndex = 1;
            this.lbThongTinPhieuXuat.Text = "THÔNG TIN PHIẾU XUẤT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.dtpNgay);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 30);
            this.panel2.TabIndex = 5;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(591, 5);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(115, 22);
            this.dtpNgay.TabIndex = 15;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH PHIẾU";
            // 
            // dgvDanhSachPhieuXuat
            // 
            this.dgvDanhSachPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDanhSachPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clNgayLap,
            this.clNguoiLap,
            this.clGhiChu,
            this.clTinhTrang});
            this.dgvDanhSachPhieuXuat.Location = new System.Drawing.Point(-2, 32);
            this.dgvDanhSachPhieuXuat.Name = "dgvDanhSachPhieuXuat";
            this.dgvDanhSachPhieuXuat.RowHeadersWidth = 51;
            this.dgvDanhSachPhieuXuat.RowTemplate.Height = 24;
            this.dgvDanhSachPhieuXuat.Size = new System.Drawing.Size(726, 561);
            this.dgvDanhSachPhieuXuat.TabIndex = 6;
            this.dgvDanhSachPhieuXuat.SelectionChanged += new System.EventHandler(this.dgvDanhSachPhieuXuat_SelectionChanged);
            // 
            // clId
            // 
            this.clId.DataPropertyName = "Id";
            this.clId.HeaderText = "Mã ";
            this.clId.MinimumWidth = 6;
            this.clId.Name = "clId";
            this.clId.Width = 125;
            // 
            // clNgayLap
            // 
            this.clNgayLap.HeaderText = "Ngày Lập";
            this.clNgayLap.MinimumWidth = 6;
            this.clNgayLap.Name = "clNgayLap";
            this.clNgayLap.Width = 125;
            // 
            // clNguoiLap
            // 
            this.clNguoiLap.HeaderText = "Người Lập";
            this.clNguoiLap.MinimumWidth = 6;
            this.clNguoiLap.Name = "clNguoiLap";
            this.clNguoiLap.Width = 125;
            // 
            // clGhiChu
            // 
            this.clGhiChu.HeaderText = "Ghi Chú";
            this.clGhiChu.MinimumWidth = 6;
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.Width = 125;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.DataPropertyName = "TinhTrangId";
            this.clTinhTrang.HeaderText = "Tình Trạng Id";
            this.clTinhTrang.MinimumWidth = 6;
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.Width = 175;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "CHI TIẾT PHIẾU XUẤT";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(726, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 38);
            this.panel3.TabIndex = 8;
            // 
            // dgvChiTietPhieuXuat
            // 
            this.dgvChiTietPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.clMaThuoc,
            this.clSoLuong});
            this.dgvChiTietPhieuXuat.Location = new System.Drawing.Point(726, 288);
            this.dgvChiTietPhieuXuat.Name = "dgvChiTietPhieuXuat";
            this.dgvChiTietPhieuXuat.RowHeadersWidth = 51;
            this.dgvChiTietPhieuXuat.RowTemplate.Height = 24;
            this.dgvChiTietPhieuXuat.Size = new System.Drawing.Size(688, 305);
            this.dgvChiTietPhieuXuat.TabIndex = 9;
            this.dgvChiTietPhieuXuat.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuXuat_CellValueChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 596);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 596);
            this.splitter2.TabIndex = 11;
            this.splitter2.TabStop = false;
            // 
            // cId
            // 
            this.cId.DataPropertyName = "Id";
            this.cId.HeaderText = "Id";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.Visible = false;
            this.cId.Width = 125;
            // 
            // clMaThuoc
            // 
            this.clMaThuoc.DataPropertyName = "MaThuoc";
            this.clMaThuoc.HeaderText = "Mã Thuốc";
            this.clMaThuoc.MinimumWidth = 6;
            this.clMaThuoc.Name = "clMaThuoc";
            this.clMaThuoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clMaThuoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clMaThuoc.Width = 400;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.MinimumWidth = 6;
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.Width = 300;
            // 
            // fXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 596);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvChiTietPhieuXuat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvDanhSachPhieuXuat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fXuatKho";
            this.Text = "Xuất Kho";
            this.Load += new System.EventHandler(this.fXuatKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuXuat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMaNhanVien;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTaoPhieuXuat;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.Label lbDienMaPhieu;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbNhanVienLapPhieu;
        private System.Windows.Forms.Label lbNgayNhapPhieu;
        private System.Windows.Forms.Label lbMaPhieu;
        private System.Windows.Forms.Label lbThongTinPhieuXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuXuat;
        private System.Windows.Forms.Button btInPhieuXuat;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewComboBoxColumn clMaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
    }
}