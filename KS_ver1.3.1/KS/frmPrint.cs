using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KS.BUS;
using KS.DTO;
using KS.DAO;

namespace KS
{
    public partial class frmPrint : Form
    {
        public int curSoPhong = 0;
        public int curID = 0;
        public frmPrint(int soPhong)
        {
            this.curSoPhong = soPhong;
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            ChiTietDao d = new ChiTietDao();
            lbRoom.Text = "Room " + this.curSoPhong.ToString();

            ChiTietDto ct = d.getPhongBySoPhong(this.curSoPhong);
            lbCheckIn.Text = ct.GioVao.ToString();
            lbCheckOut.Text = ct.GioRa.ToString();
            lbService.Text = ct.PhuThu.ToString();
            lbTotal.Text = ct.TongTien.ToString();
        }
    }
}
