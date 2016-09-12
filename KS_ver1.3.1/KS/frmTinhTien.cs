using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KS.BUS;
using KS.DTO;
using KS.DAO;

namespace KS
{
    public partial class frmTinhTien : Form
    {
        public int curSoPhong = 0;
        public int curID = 0;
        public int curTrangThai = 0;
        public int curVip = 0;
        public int curLoaiPhong = 0;
        public frmTinhTien(int soPhong)
        {
            this.curSoPhong = soPhong;
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime();
            startDate = DateTime.Now;
            txtCheckIn.Text = startDate.ToString();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DateTime endDate = new DateTime();
            endDate = DateTime.Now;
            txtCheckOut.Text = endDate.ToString();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soGio, soNgay, soPhut;
            double gia = 0;
            double tongTien = 0;
            double phuThu = 0;
            string startTemp = txtCheckIn.Text;
            string endTemp = txtCheckOut.Text;

            if (txtCheckIn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giờ vào!");
            }
            else if (txtCheckOut.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giờ ra");
            }
            else
            {
                DateTime startDate = Convert.ToDateTime(startTemp);
                DateTime endDate = Convert.ToDateTime(endTemp);

                TimeSpan interval = endDate.Subtract(startDate);

                SomeFunctionBus sfBus = new SomeFunctionBus();
            

                soGio = interval.Hours;
                soNgay = interval.Days;
                soPhut = interval.Minutes;
                if (soPhut > 12)
                {
                    soGio++;                    
                }
                soPhut = 0;
                if (soGio > 12)
                {
                    soNgay++;
                    soGio = 0;
                }
                if (cbQD.Checked)
                {
                    curLoaiPhong = 1;
                }
                if (cbLTime.Checked) {
                    curLoaiPhong = 2;
                }
                if (curLoaiPhong == 0) {
                    if (!cbVIP.Checked)
                    {
                        gia = sfBus.TienGio(soNgay, soGio) + 240000 * soNgay;                       
                    } 
                    else
                    {
    
                            gia = sfBus.TienGioVIP(soNgay, soGio) + 300000 * soNgay;
                        
                    }
                } else if (curLoaiPhong == 1)
                {
                    if (curSoPhong == 201 || curSoPhong == 301 || curSoPhong == 401 || curSoPhong == 501)
                    {
                        if (Convert.ToDouble(txtDeal.Text) != 0 && txtDeal.Visible != false)
                        {
                            gia = Convert.ToDouble(txtDeal.Text) + sfBus.PhuThuQD(startDate, endDate);
                        } else
                        {
                            gia = 220000 + sfBus.PhuThuQD(startDate, endDate);
                        }
                        if (soNgay > 0)
                        {
                            gia = gia + 350000 * (soNgay - 1);
                        }
                    } else if (cbVIP.Checked) {
                        if (Convert.ToDouble(txtDeal.Text) != 0 && txtDeal.Visible != false)
                        {
                            gia = Convert.ToDouble(txtDeal.Text) + sfBus.PhuThuQD(startDate, endDate);
                        }
                        else
                        {
                            gia = 180000 + sfBus.PhuThuQD(startDate, endDate);
                        }
                        if (soNgay > 0)
                        {
                            gia = gia + 300000 * (soNgay - 1);
                        }
                    } else
                    {
                        gia = 150000 + sfBus.PhuThuQD(startDate, endDate);
                        if (soNgay > 0)
                        {
                            gia = gia + 240000 * (soNgay - 1);
                        }
                    }
                }
                //if (!cbVIP.Checked)
                //{
                //    if (!cbQD.Checked)
                //    {
                //        gia = sfBus.TienGio(soNgay, soGio);
                //        if (Convert.ToDouble(txtDeal.Text) != 0 && txtDeal.Visible != false)
                //        {
                //            gia = gia + Convert.ToDouble(txtDeal.Text) * soNgay;
                //        }
                //        else if (curSoPhong == 201 || curSoPhong == 301 || curSoPhong == 401 || curSoPhong == 501)
                //        {
                //            gia = gia + 350000 * soNgay;
                //        }
                //        else {
                //            gia = gia + 240000 * soNgay;
                //        }
                //    }
                //    else
                //    {
                //        curLoaiPhong = 1;
                //        gia = 150000 + sfBus.PhuThuQD(startDate, endDate);
                                                
                //    }
                  
                //} else
                //{
                //    curVip = 1;
                //    if (!cbQD.Checked || soNgay > 0)
                //    {
                //        gia = sfBus.TienGioVIP(soNgay, soGio);
                //        if (Convert.ToDouble(txtDeal.Text) != 0 && txtDeal.Visible != false)
                //        {
                //            gia = gia + Convert.ToDouble(txtDeal.Text) * soNgay;
                //        }
                //        else
                //        {
                //            gia = gia + 300000 * soNgay;
                //        }
                //    }
                //    else
                //    {
                //        curLoaiPhong = 1;
                //        if (Convert.ToDouble(txtDeal.Text) != 0)
                //        {
                //            gia = Convert.ToDouble(txtDeal.Text) + sfBus.PhuThuQD(startDate, endDate);
                //        }
                //        else
                //        {
                //            gia = 220000 + sfBus.PhuThuQD(startDate, endDate);
                //        }
                //    }                
                //}
            if (txtPhuThu.Text != "")
            {
                phuThu = Convert.ToDouble(txtPhuThu.Text);
            } else
            {
                txtPhuThu.Text = "0";
            }
            tongTien = gia + phuThu;

            txtThoiGian.Text = soGio.ToString();
            txtGia.Text = gia.ToString("#,##0");
            txtTongTien.Text = tongTien.ToString("#,##0");
            if (this.curTrangThai == 2)
            {
                try
                {
                    ChiTietDto ctDto = new ChiTietDto();
                    ctDto.SoPhong = curSoPhong;
                    ctDto.Ten = txtTen.Text;
                    ctDto.GioVao = startDate;
                    ctDto.GioRa = endDate;
                    ctDto.TienGio = (double)gia;
                    ctDto.PhuThu = (double)phuThu;
                    ctDto.TongTien = (double)tongTien;
                    ctDto.GhiChu = txtGhiChu.Text;
                    ctDto.TrangThai = 3;
                    ctDto.Vip = curVip;
                    ctDto.LoaiPhong = curLoaiPhong;
                    ctDto.GiaThuongLuong = Convert.ToDouble(txtDeal.Text);
                    ctDto.Id = curID;

                    ChiTietBus ctBus = new ChiTietBus();
                    curTrangThai = 3;
                    ctBus.Sua(ctDto);
                    btnTinhTien.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                try
                {
                    ChiTietDto ctDto = new ChiTietDto();
                    ctDto.SoPhong = curSoPhong;
                    ctDto.Ten = txtTen.Text;
                    ctDto.GioVao = startDate;
                    ctDto.GioRa = endDate;
                    ctDto.TienGio = Convert.ToDouble(txtGia.Text);
                    ctDto.PhuThu = Convert.ToDouble(txtPhuThu.Text);
                    ctDto.TongTien = Convert.ToDouble(txtTongTien.Text);
                    ctDto.GhiChu = txtGhiChu.Text;
                    ctDto.TrangThai = 3;
                    ctDto.Vip = curVip;
                    ctDto.LoaiPhong = curLoaiPhong;
                    ctDto.GiaThuongLuong = Convert.ToDouble(txtDeal.Text);

                    ChiTietBus ctBus = new ChiTietBus();
                    ctBus.Them(ctDto);
                    curTrangThai = 3;
                    frmMain p = (frmMain)this.Owner;
                    p.changeBackgroundButton(curSoPhong, this.curTrangThai);
                    btnTinhTien.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }




                try
                {
                    DateTime printDate = new DateTime();
                    printDate = Convert.ToDateTime(txtCheckOut.Text).Date;


                    PrintDto ptDto = new PrintDto();
                    ptDto.PrintTime = printDate;


                    PrintBus ptBus = new PrintBus();
                    ptBus.Them(ptDto);

                    PrintDao pt = new PrintDao();

                    string STT = pt.getNumber().ToString();


                    printDialog1.Document = printDocument1;
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }


           
            
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (txtCheckIn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giờ vào!");
            }
            else
            {
                if (cbVIP.Checked)
                {
                    this.curVip = 1;
                }
                if (cbQD.Checked)
                {
                    this.curLoaiPhong = 1;
                }
                if (cbLTime.Checked)
                {
                    this.curLoaiPhong = 2;
                }
                try
                {
                    ChiTietDto ctDto = new ChiTietDto();
                    ctDto.SoPhong = curSoPhong;
                    ctDto.Ten = txtTen.Text;
                    ctDto.GioVao = Convert.ToDateTime(txtCheckIn.Text);
                    ctDto.GioRa = Convert.ToDateTime("01/01/2000 00:00:00");
                    ctDto.TienGio = Convert.ToDouble(txtGia.Text);
                    ctDto.PhuThu = Convert.ToDouble(txtPhuThu.Text);
                    ctDto.TongTien = Convert.ToDouble(txtTongTien.Text);
                    ctDto.GiaThuongLuong = Convert.ToDouble(txtDeal.Text);
                    ctDto.GhiChu = txtGhiChu.Text;
                    ctDto.TrangThai = 2;
                    ctDto.Vip = curVip;
                    ctDto.LoaiPhong = curLoaiPhong;

                    ChiTietBus ctBus = new ChiTietBus();
                    ctBus.Them(ctDto);
                    curTrangThai = 2;
                    MessageBox.Show("Đặt phòng thành công!");
                    btnDatPhong.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
            
        }

        private void frmTinhTien_Load(object sender, EventArgs e)
        {
            ChiTietDao d = new ChiTietDao();            
            lblTenPhong.Text = "Room " + this.curSoPhong.ToString();
            if (this.curSoPhong == 101 || this.curSoPhong == 205 || this.curSoPhong == 305 || this.curSoPhong == 405 || this.curSoPhong == 505) {
                cbVIP.Checked = true;
            }
            ChiTietDto ct = d.getPhongBySoPhong(this.curSoPhong);
            if (ct.TrangThai == 2)
            {
                this.curID = ct.Id;
                txtCheckIn.Text = ct.GioVao.ToString();
                txtTen.Text = ct.Ten.ToString();
                txtDeal.Text = ct.GiaThuongLuong.ToString();
                btnDatPhong.Enabled = false;
                btnCheckIn.Enabled = false;
                
                if ((int)ct.Vip == 1)
                {
                    this.curVip = 1;
                    cbVIP.Checked = true;
                } else
                {
                    this.curVip = 0;
                    cbVIP.Checked = false;
                }
                if ((int)ct.LoaiPhong == 1)
                {
                    this.curLoaiPhong = 1;
                    cbQD.Checked = true;
                }
                else if ((int)ct.LoaiPhong == 0)
                {
                    this.curLoaiPhong = 0;
                    cbQD.Checked = false;
                }
                else {
                    this.curLoaiPhong = 2;
                    cbLTime.Checked = true;
                }
            } else if (ct.TrangThai == 3)
            {
                this.curID = ct.Id;
                txtTen.Text = ct.Ten.ToString();
                txtCheckIn.Text = ct.GioVao.ToString();
                txtCheckOut.Text = ct.GioRa.ToString();
                txtGia.Text = ct.TienGio.ToString();
                txtPhuThu.Text = ct.PhuThu.ToString();
                txtGhiChu.Text = ct.GhiChu.ToString();
                txtTongTien.Text = ct.TongTien.ToString();
                txtDeal.Text = ct.GiaThuongLuong.ToString();
                if ((int)ct.Vip == 1)
                {
                    this.curVip = 1;
                    cbVIP.Checked = true;
                } else
                {
                    this.curVip = 0;
                    cbVIP.Checked = false;
                }
                if ((int)ct.LoaiPhong == 1)
                {
                    this.curLoaiPhong = 1;
                    cbQD.Checked = true;
                }
                else if ((int)ct.LoaiPhong == 0)
                {
                    this.curLoaiPhong = 0;
                    cbQD.Checked = false;
                }
                else
                {
                    this.curLoaiPhong = 2;
                    cbLTime.Checked = true;
                }
                btnDatPhong.Enabled = false;
                btnTinhTien.Enabled = false;
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = false;
            }  
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietDto ctDto = new ChiTietDto();
                ctDto.SoPhong = curSoPhong;
                ctDto.Ten = txtTen.Text;
                ctDto.GioVao = Convert.ToDateTime(txtCheckIn.Text);
                ctDto.GioRa = Convert.ToDateTime(txtCheckOut.Text);
                ctDto.TienGio = Convert.ToDouble(txtGia.Text);
                ctDto.PhuThu = Convert.ToDouble(txtPhuThu.Text);
                ctDto.TongTien = Convert.ToDouble(txtTongTien.Text);
                ctDto.GhiChu = txtGhiChu.Text;
                ctDto.TrangThai = 1;
                ctDto.Vip = curVip;
                ctDto.LoaiPhong = curLoaiPhong;
                ctDto.GiaThuongLuong = Convert.ToDouble(txtDeal.Text);
                ctDto.Id = curID;

                ChiTietBus ctBus = new ChiTietBus();
                curTrangThai = 1;
                ctBus.Sua(ctDto);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtTen.Text = "";
            txtCheckIn.Text = "";
            txtCheckOut.Text = "";
            txtThoiGian.Text = "";
            txtGia.Text = "";
            txtPhuThu.Text = "";
            txtGhiChu.Text = "";
            txtTongTien.Text = "";
            txtDeal.Text = "0";
            cbQD.Checked = false;
            cbVIP.Checked = false;

            btnDatPhong.Enabled = true;
            btnTinhTien.Enabled = true;
            btnCheckIn.Enabled = true;
            btnCheckOut.Enabled = true;
        }

        private void frmTinhTien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.curTrangThai != 0)
            {
                frmMain p = (frmMain)this.Owner;
                p.changeBackgroundButton(curSoPhong, this.curTrangThai);
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //frmPrint tinhtien = new frmPrint(this.curSoPhong);
            //tinhtien.ShowDialog(this);

            DateTime printDate = new DateTime();
            printDate = Convert.ToDateTime(txtCheckOut.Text).Date;


            PrintDto ptDto = new PrintDto();
            ptDto.PrintTime = printDate;


            PrintBus ptBus = new PrintBus();
            ptBus.Them(ptDto);

            PrintDao pt = new PrintDao();

            string STT = pt.getNumber().ToString();
            

            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void lblTenPhong_Click(object sender, EventArgs e)
        {

        }

        private void cbQD_CheckStateChanged(object sender, EventArgs e)
        {

            if (cbVIP.Checked == true && cbQD.Checked == true)
            {
                cbLTime.Checked = false;
                lbDeal.Visible = true;
                txtDeal.Visible = true;

            }
            else {
                lbDeal.Visible = false;
                txtDeal.Visible = false;
            }
        }

        private void cbVIP_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbVIP.Checked == true && cbQD.Checked == true)
            {
                cbLTime.Checked = false;
                lbDeal.Visible = true;
                txtDeal.Visible = true;

            }
            else
            {
                lbDeal.Visible = false;
                txtDeal.Visible = false;
            }
        }

        private void cbLTime_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbLTime.Checked == true)
            {
                cbQD.Checked = false;
                lbDeal.Visible = true;
                txtDeal.Visible = true;

            }
            else
            {
                lbDeal.Visible = false;
                txtDeal.Visible = false;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string giaIn = Convert.ToDouble(txtGia.Text).ToString("#,##0");
            string phuThuIn = Convert.ToDouble(txtPhuThu.Text).ToString("#,##0");
            string TongIn = Convert.ToDouble(txtTongTien.Text).ToString("#,##0");
            PrintDao pt = new PrintDao();

            string STT = pt.getNumber().ToString();
  

            e.Graphics.DrawImage(Properties.Resources.logo, 0, 0);
            e.Graphics.DrawString("SaiGon River", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 80, 15);
            e.Graphics.DrawString("ĐT: 083 740 8319", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 80, 35);
            e.Graphics.DrawString("STT: " + STT, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 0, 70);
            e.Graphics.DrawString("Tên KH: " + txtTen.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 0, 90);
            e.Graphics.DrawString("Phòng: " + curSoPhong.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 0, 110);
            e.Graphics.DrawString("Giờ vào: " + txtCheckIn.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 0, 130);
            e.Graphics.DrawString("Giờ ra: " + txtCheckOut.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 0, 150);
            e.Graphics.DrawString("Tiền phòng: " + giaIn, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 0, 170);
            e.Graphics.DrawString("Phụ thu: " + phuThuIn, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 0,  190);
            e.Graphics.DrawString("Tổng tiền: ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 0, 212);
            e.Graphics.DrawString(TongIn, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 55, 205);

            Graphics gf = e.Graphics;
            SizeF sf = gf.MeasureString("Nội dung phụ thu: " + txtGhiChu.Text,
                            new Font("Arial", 8, FontStyle.Regular), 190);
            gf.DrawString("Nội dung phụ thu: " + txtGhiChu.Text,
                            new Font("Arial", 8, FontStyle.Regular), Brushes.Black,
                            new RectangleF(new PointF(0, 230), sf),
                            StringFormat.GenericTypographic);
            //e.Graphics.DrawString("Nội dung phụ thu: " + txtGhiChu.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 0, 210);

        }
    }
}
