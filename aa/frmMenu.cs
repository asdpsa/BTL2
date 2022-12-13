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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

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
    }
}
