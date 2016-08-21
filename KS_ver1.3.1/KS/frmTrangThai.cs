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
    public partial class frmTrangThai : Form
    {
        private int soPhong = 0;
        public frmTrangThai()
        {
            InitializeComponent();
        }

        private void btnPhong1_Click(object sender, EventArgs e)
        {
            this.soPhong = 101;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog();
        }

        private void btnPhong2_Click(object sender, EventArgs e)
        {
            this.soPhong = 102;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog();
        }

        private void btnPhong3_Click(object sender, EventArgs e)
        {
            this.soPhong = 103;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog();
        }
        private void btnPhong4_Click(object sender, EventArgs e)
        {
            this.soPhong = 104;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog();
        }

        private void frmTrangThai_Load(object sender, EventArgs e)
        {

        }
    }
}
