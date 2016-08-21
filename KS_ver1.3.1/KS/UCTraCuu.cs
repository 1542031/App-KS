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
using KS.BUS;

namespace KS
{
    public partial class UCTraCuu : UserControl
    {
        public UCTraCuu()
        {
            InitializeComponent();
        }

        private void UCTraCuu_Load(object sender, EventArgs e)
        {
            dgvDanhSach.Rows.Clear();
            ChiTietDao ctdao = new ChiTietDao();
            DataSet dt = ctdao.getNotCharge();
            dgvDanhSach.DataSource = dt.Tables[0];
            // dgvDanhSach.DataBind();

            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            LevyDao lvy = new LevyDao();
            LevyDto lv = lvy.getPrevTime();
            dtpFrom.Value = lv.GioThuTien;
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            ChiTietDao ctdao = new ChiTietDao();
            DataSet dt = ctdao.getDependTime(dtpFrom.Value, dtpTo.Value);
            DataTable myTable = new DataTable();
            myTable = dt.Tables[0];
            dgvDanhSach.DataSource = myTable;

            double sum = 0;
            foreach (DataRow dr in myTable.Rows)
            {
                sum += Convert.ToDouble(dr[6]);
            }
            txtTotal.Text = sum.ToString("#,##0");


        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLevy_Click(object sender, EventArgs e)
        {
            try
            {
                LevyDto lvDto = new LevyDto();
                lvDto.GioThuTien = Convert.ToDateTime(dtpTo.Value);
                LevyBus lvBus = new LevyBus();
                lvBus.Them(lvDto);

                MessageBox.Show("Bạn đã thu " + txtTotal.Text + " lúc " + dtpTo.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLevy_Click_1(object sender, EventArgs e)
        {
            try
            {
                LevyDto lvDto = new LevyDto();
                lvDto.GioThuTien = Convert.ToDateTime(dtpTo.Value);
                lvDto.SoTien = Convert.ToDouble(txtTotal.Text);
                LevyBus lvBus = new LevyBus();
                lvBus.Them(lvDto);

                MessageBox.Show("Bạn đã thu " + txtTotal.Text + " lúc " + dtpTo.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
