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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            bttEdit.Enabled = false;
            bttDelete.Enabled = false;
            Display();
        }

        private void Display()
        {
            // TODO: This line of code loads data into the 'qLCuaHangMayTinhDataSet.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.qLCuaHangMayTinhDataSet.NhaCungCap);
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
            this.txtMNCC.Clear();
            this.txtSdt.Clear();
            this.txtTen.Clear();
            bttEdit.Enabled = false;
            bttDelete.Enabled = false;
            bttAdd.Enabled = true;
            txtMNCC.Enabled = true;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            //kiểm tra k được trống
            if (txtMNCC.Text == "")
            {
                MessageBox.Show("Mã nhà cung cấp không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMNCC.Focus();
                return;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên nhà cung cấp không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtSdt.Text == "")
            {
                MessageBox.Show("Số điện thoại không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return;
            }
            var ncc = new NhaCungCap();
            //tìm nhân viên có mã như trên form
            var emp = qlc.NhaCungCaps.FirstOrDefault(x => x.MaNCC == txtMNCC.Text);
            //nếu chưa tồn tại
            if (emp == null)
            {
                ncc.MaNCC = txtMNCC.Text;
                ncc.TenNCC = txtTen.Text;
                ncc.Diachi = txtDiachi.Text;
                ncc.sdt = txtSdt.Text;
                //lưu
                qlc.NhaCungCaps.Add(ncc);
                qlc.SaveChanges();
                Display();
                bttRefresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtMNCC.Enabled = false;
                //lấy dữ liệu từ form vào textbox
                txtMNCC.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                txtDiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                txtSdt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
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
                    var ncc = qlc.NhaCungCaps.FirstOrDefault(x => x.MaNCC == txtMNCC.Text);
                    if (ncc != null)
                    {
                        //xóa dữ liệu
                        qlc.NhaCungCaps.Remove(ncc);
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
                MessageBox.Show("Tên nhà cung cấp không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var ncc = qlc.NhaCungCaps.FirstOrDefault(x => x.MaNCC == txtMNCC.Text);
            //nếu tìm thấy
            if (ncc != null)
            {
                //gán lại thông tin cho nhân viên
                ncc.TenNCC = txtTen.Text;
                ncc.Diachi = txtDiachi.Text;
                ncc.sdt = txtSdt.Text;
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
