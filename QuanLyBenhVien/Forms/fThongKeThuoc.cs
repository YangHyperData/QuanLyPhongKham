using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.Forms
{
    public partial class fThongKeThuoc : Form
    {
        public fThongKeThuoc()
        {
            InitializeComponent();
        }

        private void fThongKeThuoc_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddDays(-7);
            dtpDenNgay.Value = DateTime.Now;
        }
        //private void LoadDSThongKeKhamBenhTrongNgay()
        //{            
           
        //}

        private void btThongKe_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = DonThuocCommon.ThongKeThuoc(dtpTuNgay.Value, dtpDenNgay.Value, 1);
            tabControl1.SelectedTab = tpgChiTiet;
        }
               
        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvTongHop.DataSource = DonThuocCommon.ThongKeThuoc(dtpTuNgay.Value, dtpDenNgay.Value, 2);
            tabControl1.SelectedTab = tpgTongHop;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvTongHopTheoNhanVienThu.DataSource = DonThuocCommon.ThongKeThuoc(dtpTuNgay.Value, dtpDenNgay.Value, 3);
            tabControl1.SelectedTab = tpgTongHopTheoNhanVienThu;
        }
    }
}
