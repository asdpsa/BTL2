using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aa
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            bttEdit.Enabled = false;
            bttDelete.Enabled = false;
            Display();
        }
        private void Display()
        {
            // TODO: This line of code loads data into the 'qLCuaHangMayTinhDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLCuaHangMayTinhDataSet.NhanVien);
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

        private void bttRefresh_Click(object sender, EventArgs e)
        {
            //xóa dữ liệu trong textbox
            this.txtDiachi.Clear();
            this.txtMNV.Clear();
            this.txtSdt.Clear();
            this.txtTen.Clear();
            txtMNV.Enabled = true;
            bttEdit.Enabled = false;
            bttDelete.Enabled = false;
            bttAdd.Enabled = true;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            //kiểm tra k được trống
            if (txtMNV.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMNV.Focus();
                return;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtSdt.Text == "")
            {
                MessageBox.Show("Số điện thoại không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return;
            }
            var nv = new NhanVien();
            //tìm nhân viên có mã như trên form
            var emp = qlc.NhanViens.FirstOrDefault(x => x.MaNV == txtMNV.Text);
            //nếu chưa tồn tại
            if (emp == null)
            {
                nv.MaNV = txtMNV.Text;
                nv.TenNV = txtTen.Text;
                nv.DiaChi = txtDiachi.Text;
                nv.sdt = txtSdt.Text;
                nv.GioiTinh = cbGt.Text;
                //lưu
                qlc.NhanViens.Add(nv);
                qlc.SaveChanges();
                Display();
                bttRefresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Mã nhân viênc đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //do work
                bttEdit.Enabled = true;
                bttDelete.Enabled = true;
                bttAdd.Enabled = false;
                txtMNV.Enabled = false;
                //lấy dữ liệu từ form vào textbox
                txtMNV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                cbGt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                txtDiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                txtSdt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                position = dataGridView1.CurrentRow.Index;
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            //kiểm tra xem đã chọn dòng chưa
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //tìm nhân viên có mã như trên form
                    var nv = qlc.NhanViens.FirstOrDefault(x => x.MaNV == txtMNV.Text);
                    if (nv != null)
                    {
                        //xóa dữ liệu
                        qlc.NhanViens.Remove(nv);
                        //lưu
                        qlc.SaveChanges();
                        //hiển thị lại dữ liệu
                        Display();
                        bttRefresh_Click(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            //kiểm tra k được trống
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtSdt.Text == "")
            {
                MessageBox.Show("Số điện thoại không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return;
            }
            //tìm nhân viên cần sửa có mã như trên form
            var nv = qlc.NhanViens.FirstOrDefault(x => x.MaNV == txtMNV.Text);
            //nếu tìm thấy
            if (nv != null)
            {
                //gán lại thông tin cho nhân viên
                nv.TenNV = txtTen.Text;
                nv.DiaChi = txtDiachi.Text;
                nv.sdt = txtSdt.Text;
                nv.GioiTinh = cbGt.Text;
                //lưu
                qlc.SaveChanges();
                //hiển thị lại dữ liệu
                Display();
                //hiển thị đúng vị trí dòng đã chọn trước đó
                dataGridView1.Rows[0].Selected = false;
                dataGridView1.Rows[position].Selected = true;
                bttRefresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
