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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            bttEdit.Enabled = false;
            bttDelete.Enabled = false;
            Display();
        }
        private void Display()
        {
            // TODO: This line of code loads data into the 'qLCuaHangMayTinhDataSet.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.qLCuaHangMayTinhDataSet.NhaCungCap);
            // TODO: This line of code loads data into the 'qLCuaHangMayTinhDataSet.ThongTinMayTinh' table. You can move, or remove it, as needed.
            this.thongTinMayTinhTableAdapter.Fill(this.qLCuaHangMayTinhDataSet.ThongTinMayTinh);
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
            this.txtMMT.Clear();
            txtGb.Text = "0";
            this.txtTen.Clear();
            bttEdit.Enabled = false;
            bttDelete.Enabled = false;
            bttAdd.Enabled = true;
            txtMMT.Enabled = true;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            //kiểm tra k được trống
            if (txtMMT.Text == "")
            {
                MessageBox.Show("Mã máy tính không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMMT.Focus();
                return;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên máy tính không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtGb.Text == "")
            {
                MessageBox.Show("Giá bán không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGb.Focus();
                return;
            }
            //loại bỏ dấu "," trong chuỗi
            string gb = txtGb.Text.ToString().Replace(",", string.Empty);

            var ttmt = new ThongTinMayTinh();
            //tìm nhân viên có mã như trên form
            var emp = qlc.ThongTinMayTinhs.FirstOrDefault(x => x.MaMT == txtMMT.Text);
            //nếu chưa tồn tại
            if (emp == null)
            {
                ttmt.MaMT = txtMMT.Text;
                ttmt.tenmt = txtTen.Text;
                ttmt.giaban = Convert.ToInt32(gb);
                ttmt.MaNCC = comboBox1.Text;
                //lưu
                qlc.ThongTinMayTinhs.Add(ttmt);
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
                txtMMT.Enabled = false;
                //lấy dữ liệu từ form vào textbox
                txtMMT.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                txtGb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
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
                    var ttmt = qlc.ThongTinMayTinhs.FirstOrDefault(x => x.MaMT == txtMMT.Text);
                    if (ttmt != null)
                    {
                        //xóa dữ liệu
                        qlc.ThongTinMayTinhs.Remove(ttmt);
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
                MessageBox.Show("Tên máy tính không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtGb.Text == "")
            {
                MessageBox.Show("Giá bán không được trống.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGb.Focus();
                return;
            }
            //loại bỏ dấu "," trong chuỗi
            string gb = txtGb.Text.ToString().Replace(",", string.Empty);
            //tìm nhân viên cần sửa có mã như trên form
            var ttmt = qlc.ThongTinMayTinhs.FirstOrDefault(x => x.MaMT == txtMMT.Text);
            //nếu tìm thấy
            if (ttmt != null)
            {
                //gán lại thông tin cho nhân viên
                ttmt.tenmt = txtTen.Text;
                ttmt.giaban = Convert.ToInt32(gb);
                ttmt.MaNCC = comboBox1.Text;
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

        private void txtGb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGb_TextChanged(object sender, EventArgs e)
        {
            if (txtGb.Text != "")
            {
                decimal value = decimal.Parse(txtGb.Text, NumberStyles.AllowThousands);
                txtGb.Text = String.Format("{0:N0}", value);
                txtGb.Select(txtGb.Text.Length, 0);
            }
            else
            {
                txtGb.Text = "0";
            }
        }
    }
}
