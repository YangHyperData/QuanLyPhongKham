namespace QuanLyBenhVien.Forms
{
    partial class fThongKeKhamBenh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongKeKhamBenh));
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgChiTiet = new System.Windows.Forms.TabPage();
            this.tpgTongHop = new System.Windows.Forms.TabPage();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.btThongKe = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpgChiTiet.SuspendLayout();
            this.tpgTongHop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(146, 19);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(157, 28);
            this.dtpTuNgay.TabIndex = 0;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.Location = new System.Drawing.Point(3, 3);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1445, 512);
            this.dgvThongKe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ Ngày";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.btThongKe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 68);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ Ngày";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(442, 19);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(157, 28);
            this.dtpDenNgay.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgChiTiet);
            this.tabControl1.Controls.Add(this.tpgTongHop);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1459, 552);
            this.tabControl1.TabIndex = 5;
            // 
            // tpgChiTiet
            // 
            this.tpgChiTiet.Controls.Add(this.dgvThongKe);
            this.tpgChiTiet.Location = new System.Drawing.Point(4, 30);
            this.tpgChiTiet.Name = "tpgChiTiet";
            this.tpgChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tpgChiTiet.Size = new System.Drawing.Size(1451, 518);
            this.tpgChiTiet.TabIndex = 0;
            this.tpgChiTiet.Text = "Thống Kê Chi Tiết";
            this.tpgChiTiet.UseVisualStyleBackColor = true;
            // 
            // tpgTongHop
            // 
            this.tpgTongHop.Controls.Add(this.dgvTongHop);
            this.tpgTongHop.Location = new System.Drawing.Point(4, 30);
            this.tpgTongHop.Name = "tpgTongHop";
            this.tpgTongHop.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTongHop.Size = new System.Drawing.Size(1451, 524);
            this.tpgTongHop.TabIndex = 1;
            this.tpgTongHop.Text = "Thống Kê Tổng Hợp";
            this.tpgTongHop.UseVisualStyleBackColor = true;
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTongHop.Location = new System.Drawing.Point(3, 3);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.RowHeadersWidth = 51;
            this.dgvTongHop.RowTemplate.Height = 24;
            this.dgvTongHop.Size = new System.Drawing.Size(1445, 518);
            this.dgvTongHop.TabIndex = 2;
            // 
            // btThongKe
            // 
            this.btThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThongKe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThongKe.ImageIndex = 6;
            this.btThongKe.ImageList = this.imageList1;
            this.btThongKe.Location = new System.Drawing.Point(645, 10);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btThongKe.Size = new System.Drawing.Size(244, 42);
            this.btThongKe.TabIndex = 2;
            this.btThongKe.Text = "    Thống Kê Chi Tiết";
            this.btThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "doctor.png");
            this.imageList1.Images.SetKeyName(1, "he thong.png");
            this.imageList1.Images.SetKeyName(2, "kham suc khoe.png");
            this.imageList1.Images.SetKeyName(3, "kho duoc.png");
            this.imageList1.Images.SetKeyName(4, "login.png");
            this.imageList1.Images.SetKeyName(5, "noi tru.png");
            this.imageList1.Images.SetKeyName(6, "thong ke.png");
            this.imageList1.Images.SetKeyName(7, "vien phi.png");
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(913, 11);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(283, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "    Thống Kê Tổng Hợp";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fThongKeKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 620);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "fThongKeKhamBenh";
            this.Text = "Thống Kê Khám Bệnh";
            this.Load += new System.EventHandler(this.fThongKeKhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpgChiTiet.ResumeLayout(false);
            this.tpgTongHop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgChiTiet;
        private System.Windows.Forms.TabPage tpgTongHop;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
    }
}