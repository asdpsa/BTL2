using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace aa
{
    public partial class frmSaleBill : Form
    {
        public frmSaleBill()
        {
            InitializeComponent();
        }

        //khai báo biến chứa dòng hiện tại
        int position;
        //Khởi tạo đối tượng quản lý Database (DataContext)
        QLCuaHangMayTinhEntities qlc = new QLCuaHangMayTinhEntities();

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)

        {
            DialogResult check;
            check = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupplier frm = new frmSupplier();
            frm.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer frm = new frmCustomer();
            frm.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee frm = new frmEmployee();
            frm.Show();
        }

        private void thôngTinMáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void bánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSaleBill frm = new frmSaleBill();
            frm.Show();
        }

        private void frmSaleBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCuaHangMayTinhDataSet.ThongTinMayTinh' table. You can move, or remove it, as needed.
            this.thongTinMayTinhTableAdapter.Fill(this.qLCuaHangMayTinhDataSet.ThongTinMayTinh);
            // TODO: This line of code loads data into the 'qLCuaHangMayTinhDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLCuaHangMayTinhDataSet.KhachHang);
            // TODO: This line of code loads data into the 'qLCuaHangMayTinhDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLCuaHangMayTinhDataSet.NhanVien);
        }

        //private void LoadDataGirdView()
        //{
        //    int i = 0;
        //    foreach (var item in qlc.ChiTietHDBs)
        //    {
        //        if (item.MaHDB == txtMDH.Text)
        //        {
        //            // Tạo một hàng mới.
        //            int rowId = dgvChiTiet.Rows.Add();
        //            // Lấy ra hàng mới
        //            DataGridViewRow row = dgvChiTiet.Rows[rowId];
        //            // Lưu dữ liệu
        //            row.Cells["Column1"].Value = item.MaMT;
        //            var mt = qlc.ThongTinMayTinhs.FirstOrDefault(x => x.MaMT == item.MaMT);
        //            row.Cells["Column2"].Value = mt.tenmt;
        //            row.Cells["Column3"].Value = item.soluong;
        //            row.Cells["Column4"].Value = item.thanhtien;
        //            i++;
        //        }
        //    }
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            Boolean check = true;
            if (nrdSL.Value == 0)
            {
                MessageBox.Show("Chưa nhập số lương!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
                nrdSL.Focus();
            }
            for (int i = 0; i < dgvChiTiet.RowCount; i++)
            {
                if (cbxMMT.Text == dgvChiTiet.Rows[i].Cells["Column1"].Value.ToString())
                {
                    MessageBox.Show("Đã có sản phẩm này!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                }
            }
            if (check == true)
            {
                double tong = 0, thanhTien;
                //lấy thông tin theo mã
                var mt = qlc.ThongTinMayTinhs.FirstOrDefault(x => x.MaMT == cbxMMT.Text);
                // Tạo một hàng mới.
                int rowId = dgvChiTiet.Rows.Add();
                // Lấy ra hàng mới
                DataGridViewRow row = dgvChiTiet.Rows[rowId];
                // Lưu dữ liệu
                row.Cells["Column1"].Value = cbxMMT.SelectedValue;
                row.Cells["Column2"].Value = txtTMT.Text;
                row.Cells["Column3"].Value = nrdSL.Value;
                thanhTien = Convert.ToDouble(nrdSL.Value * mt.giaban);
                row.Cells["Column4"].Value = thanhTien;
                txtTong.Text = dgvChiTiet.Rows.Count.ToString();
                for (int i = 0; i < dgvChiTiet.Rows.Count; i++)
                {
                    tong = tong + Convert.ToDouble(dgvChiTiet.Rows[i].Cells["Column4"].Value);
                    txtTong.Text = tong.ToString();
                }
            }
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            txtMDH.Clear();
            txtNgay.Clear();
            txtTKH.Clear();
            txtSDT.Clear();
            txtTNV.Clear();
            txtDiaChi.Clear();
            txtTMT.Clear();
            txtGB.Clear();
            txtTong.Text = "0";
            nrdSL.Value = 0;
            dgvChiTiet.Rows.Clear();
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            txtMDH.Text = DateTime.Now.ToString("yyyyMMddHHmmsss");
            txtNgay.Text = DateTime.Now.ToString();
        }

        private void cbxMMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            var emp = qlc.ThongTinMayTinhs.FirstOrDefault(x => x.MaMT == cbxMMT.Text);
            if (emp != null)
            {
                txtTMT.Text = emp.tenmt.ToString();
                txtGB.Text = emp.giaban.ToString();
            }
        }

        private void cbxMNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var emp = qlc.NhanViens.FirstOrDefault(x => x.MaNV == cbxMNV.Text);
            if (emp != null)
            {
                txtTNV.Text = emp.TenNV.ToString();
            }
        }

        private void cbxMKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            var emp = qlc.KhachHangs.FirstOrDefault(x => x.MaKH == cbxMKH.Text);
            if (emp != null)
            {
                txtTKH.Text = emp.TenKH.ToString();
                txtSDT.Text = emp.sdt.ToString();
                txtDiaChi.Text = emp.DiaChi.ToString();
            }
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (true)
            {
                //kiểm tra các lỗi
                if (txtMDH.Text == "")
                {
                    MessageBox.Show("Chưa có mã hóa đơn!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTong.Text == "")
                {
                    MessageBox.Show("Chưa có sản phẩm nào!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //loại bỏ dấu "," trong chuỗi
                string tong = txtTong.Text.ToString().Replace(",", string.Empty);
                //Lưu hóa đơn bán
                var hdb = new Hoadonban();
                hdb.MaHDB = txtMDH.Text;
                hdb.MaNV = cbxMNV.Text;
                hdb.MaKH = cbxMKH.Text;
                hdb.Ngayban = DateTime.Parse(txtNgay.Text);
                hdb.Tongtien = Convert.ToDouble(tong);
                qlc.Hoadonbans.Add(hdb);
                qlc.SaveChanges();
                //lưu chi tiết hóa đơn
                for (int i = 0; i < dgvChiTiet.RowCount; i++)
                {
                    var ct = new ChiTietHDB();
                    ct.MaHDB = txtMDH.Text;
                    ct.MaMT = dgvChiTiet.Rows[i].Cells["Column1"].Value.ToString().Trim();
                    ct.soluong = Convert.ToInt32(dgvChiTiet.Rows[i].Cells["Column3"].Value.ToString().Trim());
                    ct.thanhtien = Convert.ToDouble(dgvChiTiet.Rows[i].Cells["Column4"].Value.ToString().Trim());
                    qlc.ChiTietHDBs.Add(ct);
                    qlc.SaveChanges();
                }
                MessageBox.Show("Lưu thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bttHuy_Click(sender, e);
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            dgvHDB.Rows.Clear();
            var hdb = from emp in qlc.Hoadonbans
                      where emp.MaHDB.Contains(txtTK.Text)
                      select new
                      {
                          MHD = emp.MaHDB,
                          MNV = emp.MaNV,
                          MKH = emp.MaKH,
                          NB = emp.Ngayban,
                          TT = emp.Tongtien,
                      };
            foreach (var emp in hdb)
            {
                // Thêm hàng mới
                int rowId = dgvHDB.Rows.Add();
                // Lấy ra hàng mới
                DataGridViewRow row = dgvHDB.Rows[rowId];
                // Đỏ dữ liệu
                row.Cells["Column5"].Value = emp.MHD;
                row.Cells["Column6"].Value = emp.MNV;
                row.Cells["Column7"].Value = emp.MKH;
                row.Cells["Column8"].Value = emp.NB;
                row.Cells["Column9"].Value = emp.TT;
            }
        }

        private void dgvChiTiet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTiet.CurrentRow != null && e.RowIndex != -1)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    position = dgvChiTiet.CurrentRow.Index;
                    dgvChiTiet.Rows.Remove(dgvChiTiet.Rows[position]);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đổ dữ liệu
            txtMDH.Text = dgvHDB.Rows[e.RowIndex].Cells["Column5"].Value.ToString().Trim();
            cbxMKH.Text = dgvHDB.Rows[e.RowIndex].Cells["Column7"].Value.ToString().Trim();
            cbxMKH_SelectedIndexChanged(sender, e);
            cbxMNV.Text = dgvHDB.Rows[e.RowIndex].Cells["Column6"].Value.ToString().Trim();
            cbxMNV_SelectedIndexChanged(sender, e);
            txtNgay.Text = dgvHDB.Rows[e.RowIndex].Cells["Column8"].Value.ToString().Trim();
            txtTong.Text = dgvHDB.Rows[e.RowIndex].Cells["Column9"].Value.ToString().Trim();
            dgvChiTiet.Rows.Clear();
            // 
            var hdb = from emp in qlc.ChiTietHDBs
                      where emp.MaHDB.Contains(txtMDH.Text)
                      select new
                      {
                          MHD = emp.MaHDB,
                          MMT = emp.MaMT,
                          SL = emp.soluong,
                          TT = emp.thanhtien,
                      };
            foreach (var emp in hdb)
            {
                // Thêm hàng mới
                int rowId = dgvChiTiet.Rows.Add();
                // Lấy ra hàng mới
                DataGridViewRow row = dgvChiTiet.Rows[rowId];
                // Đổ dư liệu ra dgv
                row.Cells["Column1"].Value = emp.MMT;
                var tenmt = qlc.ThongTinMayTinhs.FirstOrDefault(x => x.MaMT == emp.MMT);
                row.Cells["Column2"].Value = tenmt.tenmt;
                row.Cells["Column3"].Value = emp.SL;
                row.Cells["Column4"].Value = emp.TT;
            }
        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {
            if (txtTong.Text !="")
            {
                decimal value = decimal.Parse(txtTong.Text, NumberStyles.AllowThousands);
                txtTong.Text = String.Format("{0:N0}", value);
                txtTong.Select(txtTong.Text.Length, 0);
            }
            else
            {
                txtTong.Text = "0";
            }
        }
    }
}
