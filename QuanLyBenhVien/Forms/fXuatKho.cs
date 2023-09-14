using QuanLyBenhVien.cs;
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

    public partial class fXuatKho : Form
    {
        decimal PhieuXuatId;
        PhieuXuat PhieuXuatHT;

        bool load = false;
        public fXuatKho()
        {
            InitializeComponent();
        }

        private void fXuatKho_Load(object sender, EventArgs e)
        {

            clMaThuoc.DataSource = PhieuXuatCommon.PhieuXuat_Select_ThongTinThuoc();
            clMaThuoc.DisplayMember = "Thongtin";
            clMaThuoc.ValueMember = "Id";

            dgvChiTietPhieuXuat.AutoGenerateColumns = false;
            dgvDanhSachPhieuXuat.AutoGenerateColumns = false;
            LoadDSPhieu();
            load = true;
        }
        private void LoadDSPhieu()
        {
            dgvDanhSachPhieuXuat.DataSource = PhieuXuatCommon.PhieuXuat_Select_Ngay(dtpNgay.Value);

        }

        private void btTaoPhieuXuat_Click(object sender, EventArgs e)
        {
            //tao phieu xuat
            PhieuXuatId = PhieuXuatCommon.Insert(Common.NhanVienHT.Id, DateTime.Now, DateTime.Now, Common.NhanVienHT.Id, tbGhiChu.Text, 1, 1);
            MessageBox.Show("Nhập Thành Công");
            LoadDS();

        }
        private void LoadDS()
        {
            dgvChiTietPhieuXuat.DataSource = ChiTietPhieuXuatCommon.Select_field("MaPhieuXuat", new object[] { PhieuXuatId });
        }

        private void dgvChiTietPhieuXuat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (load == false) return;
                if (PhieuXuatId == 0)
                {
                    MessageBox.Show("Chưa Nhập Phiếu");
                    return;
                }
                PhieuXuatHT = new PhieuXuat(PhieuXuatId);
                //if (PhieuXuatId.TinhTrangId == 2)
                //{
                //    MessageBox.Show("Phiếu này đã nhập không thể chỉnh sửa");
                //    return;
                //}
                string TenCot = dgvChiTietPhieuXuat.Columns[e.ColumnIndex].Name;

                if (dgvChiTietPhieuXuat.CurrentRow != null)
                    if (dgvChiTietPhieuXuat.CurrentRow.Cells["cId"].Value.ToString() == "")  // chua co gia tri Id tuc la dong moi
                    {
                        if (TenCot == "clMaThuoc")
                        {
                            // Nếu thêm tên thì mình tạo dòng mới luôn và refresh lại ds
                            decimal ChitietPhieuXuatId = ChiTietPhieuXuatCommon.Insert(PhieuXuatId, 1, 1, 1);
                            LoadDS();
                        }
                    }
                    else  // voi dong cu thi update thong tin nếu phiếu nhập ID > 0
                    {

                        if (TenCot == "clMaThuoc")
                        {
                            ChiTietPhieuXuat HT = new ChiTietPhieuXuat((decimal)dgvChiTietPhieuXuat.CurrentRow.Cells["cId"].Value);
                            HT.MaKhoThuoc = (decimal)dgvChiTietPhieuXuat.CurrentRow.Cells["clMaThuoc"].Value;
                        }

                        if (TenCot == "clSoLuong")
                        {
                            ChiTietPhieuXuat HT = new ChiTietPhieuXuat((decimal)dgvChiTietPhieuXuat.CurrentRow.Cells["cId"].Value);
                            HT.SoLuong = (decimal)dgvChiTietPhieuXuat.CurrentRow.Cells["clSoLuong"].Value;
                        }

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvDanhSachPhieuXuat_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachPhieuXuat.Rows[dgvDanhSachPhieuXuat.CurrentCell.RowIndex].Cells["clId"].Value != null)
                {
                    PhieuXuatHT = new PhieuXuat((decimal.Parse(dgvDanhSachPhieuXuat.Rows[dgvDanhSachPhieuXuat.CurrentCell.RowIndex].Cells["clId"].Value.ToString())));
                    tbMaNhanVien.Text = PhieuXuatHT.NguoiLap.ToString();
                    tbGhiChu.Text = PhieuXuatHT.GhiChu.ToString();
                    dtpNgayLapPhieu.Value = PhieuXuatHT.NgayLap;
                    PhieuXuatId = PhieuXuatHT.Id;
                    LoadDS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            PhieuXuatHT.NguoiLap = Common.NhanVienHT.Id;
            PhieuXuatHT.GhiChu = tbGhiChu.Text;
            PhieuXuatHT.NgayLap = dtpNgayLapPhieu.Value;
            LoadDS();

        }

        private void btInPhieuXuat_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvChiTietPhieuXuat.DataSource;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhoThuoc a = new KhoThuoc((decimal)dt.Rows[i]["Id"]);
                    a.SoLuong = a.SoLuong - (decimal)dt.Rows[i]["SoLuong"];

                }
                PhieuXuatCommon.Update_TinhTrangId(PhieuXuatId, 2);
                MessageBox.Show("Đã thực hiện");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadDSPhieu();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
