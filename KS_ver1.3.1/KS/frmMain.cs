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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void processMainPanel()
        {
            mainPanel.Controls.Clear();
        }

        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processMainPanel();
            TrangThaiPhong ucTTP = new TrangThaiPhong();
            mainPanel.Controls.Add(ucTTP);
        }

        public void changeBackgroundButton (int phong, int mau)
        {
            Button btn = (Button)this.Controls.Find("btnPhong" + phong.ToString(), true)[0];
            if (mau == 1)
            {
                btn.BackColor = Color.Lime;
            }
            else if (mau == 2)
            {
                btn.BackColor = Color.Red;
            }
            else if (mau == 3)
            {
                btn.BackColor = Color.Yellow;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            processMainPanel();
            TrangThaiPhong ucTTP = new TrangThaiPhong();
            mainPanel.Controls.Add(ucTTP);
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processMainPanel();
            UCTraCuu ucTC = new UCTraCuu();
            mainPanel.Controls.Add(ucTC);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
