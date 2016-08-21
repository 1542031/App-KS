using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KS.DAO;
using KS.DTO;

namespace KS
{
    public partial class TrangThaiPhong : UserControl
    {
        private int soPhong = 0;
        public TrangThaiPhong()
        {
            InitializeComponent();
        }

        private void btnPhong1_Click(object sender, EventArgs e)
        {
            this.soPhong = 101;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong2_Click_1(object sender, EventArgs e)
        {
            this.soPhong = 102;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong3_Click(object sender, EventArgs e)
        {
            this.soPhong = 103;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }
        private void btnPhong4_Click(object sender, EventArgs e)
        {
            this.soPhong = 104;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }
        private void btnPhong5_Click(object sender, EventArgs e)
        {
            this.soPhong = 201;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }
        private void btnPhong6_Click(object sender, EventArgs e)
        {
            this.soPhong = 202;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }
        private void btnPhong7_Click(object sender, EventArgs e)
        {
            this.soPhong = 203;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }
        private void TrangThaiPhong_Load(object sender, EventArgs e)
        {
            ChiTietDao ctdao = new ChiTietDao();
            DataSet dt = ctdao.getAllTemp();
            
            for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
            {
                int trangThaiTemp = Int32.Parse(dt.Tables[0].Rows[i][2].ToString());
                int soPhongTemp = Int32.Parse(dt.Tables[0].Rows[i][1].ToString());
                if (trangThaiTemp == 1)
                {
                    Button btn = (Button)this.Controls.Find("btnPhong" + soPhongTemp.ToString(), true)[0];
                    btn.BackColor = Color.Lime;
                }
                else if (trangThaiTemp == 2)
                {
                    Button btn = (Button)this.Controls.Find("btnPhong" + soPhongTemp.ToString(), true)[0];
                    btn.BackColor = Color.Red;
                }
                else if (trangThaiTemp == 3)
                {
                    Button btn = (Button)this.Controls.Find("btnPhong" + soPhongTemp.ToString(), true)[0];
                    btn.BackColor = Color.Yellow;
                }
            }


            //for (int i = 1; i <= 24; i++)
            //{
            //    trangThaiTemp = (int)dt.Tables[0].Rows[i-1][2];
            //    soPhongTemp = (int)dt.Tables[0].Rows[i - 1][1];
            //    //ChiTietDto ctdto = ct.getPhongBySoPhong(i);
            //    if (trangThaiTemp == 1)
            //    {
            //        Button btn = (Button)this.Controls.Find("btnPhong" + i.ToString(), true)[0];
            //        btn.BackColor = Color.Lime;
            //    } else if (trangThaiTemp == 2)
            //    {
            //        Button btn = (Button)this.Controls.Find("btnPhong" + i.ToString(), true)[0];
            //        btn.BackColor = Color.Red;
            //    } else if (trangThaiTemp == 3)
            //    {
            //        Button btn = (Button)this.Controls.Find("btnPhong" + i.ToString(), true)[0];
            //        btn.BackColor = Color.Yellow;
            //    }
            //}
        }

        private void btnPhong8_Click(object sender, EventArgs e)
        {
            this.soPhong = 204;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong9_Click(object sender, EventArgs e)
        {
            this.soPhong = 205;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong10_Click(object sender, EventArgs e)
        {
            this.soPhong = 301;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong11_Click(object sender, EventArgs e)
        {
            this.soPhong = 302;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong12_Click(object sender, EventArgs e)
        {
            this.soPhong = 303;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong13_Click(object sender, EventArgs e)
        {
            this.soPhong = 304;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong14_Click(object sender, EventArgs e)
        {
            this.soPhong = 305;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong15_Click(object sender, EventArgs e)
        {
            this.soPhong = 401;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong16_Click(object sender, EventArgs e)
        {
            this.soPhong = 402;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong17_Click(object sender, EventArgs e)
        {
            this.soPhong = 403;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong18_Click(object sender, EventArgs e)
        {
            this.soPhong = 404;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong19_Click(object sender, EventArgs e)
        {
            this.soPhong = 405;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong20_Click(object sender, EventArgs e)
        {
            this.soPhong = 501;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong21_Click(object sender, EventArgs e)
        {
            this.soPhong = 502;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong22_Click(object sender, EventArgs e)
        {
            this.soPhong = 503;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong23_Click(object sender, EventArgs e)
        {
            this.soPhong = 504;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }

        private void btnPhong24_Click(object sender, EventArgs e)
        {
            this.soPhong = 505;
            frmTinhTien tinhtien = new frmTinhTien(this.soPhong);
            tinhtien.ShowDialog(this);
        }
    }
}
