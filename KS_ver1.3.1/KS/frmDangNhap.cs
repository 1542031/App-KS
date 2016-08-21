using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KS
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "123456")
            {
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Sai mật khẩu");
            }
        }
    }
}
