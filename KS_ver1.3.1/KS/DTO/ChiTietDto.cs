using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS.DTO
{
    public class ChiTietDto
    {
        private int id;
        private int soPhong;
        private string ten;
        private DateTime gioVao;
        private DateTime gioRa;
        private double tienGio;
        private double phuThu;
        private double tongTien;
        private string ghiChu;
        private int trangThai;
        private int vip;
        private int loaiPhong;
        private double giaThuongLuong;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int SoPhong
        {
            get { return soPhong; }
            set { soPhong = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public DateTime GioVao
        {
            get { return gioVao; }
            set { gioVao = value; }
        }

        public DateTime GioRa
        {
            get { return gioRa; }
            set { gioRa = value; }
        }

        public double TienGio
        {
            get { return tienGio; }
            set { tienGio = value; }
        }

        public double PhuThu
        {
            get { return phuThu; }
            set { phuThu = value; }
        }

        public double TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public int Vip
        {
            get { return vip; }
            set { vip = value; }
        }
        public int LoaiPhong
        {
            get { return loaiPhong; }
            set { loaiPhong = value; }
        }
        public double GiaThuongLuong
        {
            get { return giaThuongLuong; }
            set { giaThuongLuong = value; }
        }
        public ChiTietDto()
        {
            id = 0;
            soPhong = 0;
            ten = "";
            gioVao = new DateTime(1, 1, 1, 1, 1, 1);
            gioRa = new DateTime(1, 1, 1, 1, 1, 1);
            tienGio = 0;
            phuThu = 0;
            tongTien = 0;
            ghiChu = "";
            trangThai = 1;
            vip = 0;
            loaiPhong = 1;
            giaThuongLuong = 0;
        }
    }

   
}
