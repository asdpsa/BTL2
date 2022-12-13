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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "") && (this.txtPass.Text == ""))
            {
                this.Hide();
                frmSaleBill frm = new frmSaleBill();
                frm.Show();
            }
            else
            {
                MessageBox.Show("không đúng tên người dùng / mật khẩu!!!", "Thông báo");
                this.txtUser.Clear();
                this.txtPass.Clear();
                this.txtUser.Focus();
            }
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            DialogResult check;
            check = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
