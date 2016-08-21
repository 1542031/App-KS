using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using KS.DTO;

namespace KS.DAO
{
    public class ChiTietDao
    {
        public void Them(ChiTietDto ctDto)
        {
            OleDbConnection cn;
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Insert into ChiTietDatPhong(SoPhong, Ten, GioVao, GioRa, TienGio, PhuThu, TongTien, GhiChu, TrangThai, VIP, LoaiPhong, GiaThuongLuong) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" +
            "";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@SoPhong", OleDbType.Integer);
            cmd.Parameters.Add("@Ten", OleDbType.WChar);
            cmd.Parameters.Add("@GioVao", OleDbType.Date);
            cmd.Parameters.Add("@GioRa", OleDbType.Date);
            cmd.Parameters.Add("@TienGio", OleDbType.Double);
            cmd.Parameters.Add("@PhuThu", OleDbType.Double);
            cmd.Parameters.Add("@TongTien", OleDbType.Double);
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar);
            cmd.Parameters.Add("@TrangThai", OleDbType.Integer);
            cmd.Parameters.Add("@VIP", OleDbType.Integer);
            cmd.Parameters.Add("@LoaiPhong", OleDbType.Integer);
            cmd.Parameters.Add("@GiaThuongLuong", OleDbType.Double);
            cmd.Parameters["@SoPhong"].Value = ctDto.SoPhong;
            cmd.Parameters["@Ten"].Value = ctDto.Ten;
            cmd.Parameters["@GioVao"].Value = ctDto.GioVao;
            cmd.Parameters["@GioRa"].Value = ctDto.GioRa;
            cmd.Parameters["@TienGio"].Value = ctDto.TienGio;
            cmd.Parameters["@PhuThu"].Value = ctDto.PhuThu;
            cmd.Parameters["@TongTien"].Value = ctDto.TongTien;
            cmd.Parameters["@GhiChu"].Value = ctDto.GhiChu;
            cmd.Parameters["@TrangThai"].Value = ctDto.TrangThai;
            cmd.Parameters["@VIP"].Value = ctDto.Vip;
            cmd.Parameters["@LoaiPhong"].Value = ctDto.LoaiPhong;
            cmd.Parameters["@GiaThuongLuong"].Value = ctDto.GiaThuongLuong;
            cmd.ExecuteNonQuery();
            strSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(strSQL, cn);
            ctDto.Id = (int)cmd.ExecuteScalar();
            // B5: Dong ket noi CSDL
            cn.Close();
        }

        public void Sua(ChiTietDto ctDto)
        {
            OleDbConnection cn;
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Update ChiTietDatPhong Set SoPhong = ?, Ten = ?, GioVao = ?, GioRa = ?, TienGio = ?, PhuThu = ? " +
            ", TongTien = ?, GhiChu = ?, TrangThai = ?, VIP = ?, LoaiPhong = ?, GiaThuongLuong = ? Where ID = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@SoPhong", OleDbType.Integer);
            cmd.Parameters.Add("@Ten", OleDbType.WChar);            
            cmd.Parameters.Add("@GioVao", OleDbType.Date);
            cmd.Parameters.Add("@GioRa", OleDbType.Date);
            cmd.Parameters.Add("@TienGio", OleDbType.Double);
            cmd.Parameters.Add("@PhuThu", OleDbType.Double);
            cmd.Parameters.Add("@TongTien", OleDbType.Double);
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar);
            cmd.Parameters.Add("@TrangThai", OleDbType.Integer);
            cmd.Parameters.Add("@VIP", OleDbType.Integer);
            cmd.Parameters.Add("@LoaiPhong", OleDbType.Integer);
            cmd.Parameters.Add("@GiaThuongLuong", OleDbType.Double); 
            cmd.Parameters.Add("@Id", OleDbType.Integer);

            cmd.Parameters["@SoPhong"].Value = ctDto.SoPhong;
            cmd.Parameters["@Ten"].Value = ctDto.Ten;
            cmd.Parameters["@GioVao"].Value = ctDto.GioVao;
            cmd.Parameters["@GioRa"].Value = ctDto.GioRa;
            cmd.Parameters["@TienGio"].Value = ctDto.TienGio;
            cmd.Parameters["@PhuThu"].Value = ctDto.PhuThu;
            cmd.Parameters["@TongTien"].Value = ctDto.TongTien;
            cmd.Parameters["@GhiChu"].Value = ctDto.GhiChu;
            cmd.Parameters["@TrangThai"].Value = ctDto.TrangThai;
            cmd.Parameters["@VIP"].Value = ctDto.Vip;
            cmd.Parameters["@LoaiPhong"].Value = ctDto.LoaiPhong;
            cmd.Parameters["@GiaThuongLuong"].Value = ctDto.GiaThuongLuong; 
            cmd.Parameters["@Id"].Value = ctDto.Id;
            cmd.ExecuteNonQuery();
            // B5: Dong ket noi CSDL
            cn.Close();
        }
        public void UpdateByID(ChiTietDto ctDto)
        {
            OleDbConnection cn;
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Update ChiTietDatPhong Set TrangThai = ? Where ID = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@TrangThai", OleDbType.Integer);
            cmd.Parameters.Add("@Id", OleDbType.Integer);

            cmd.Parameters["@TrangThai"].Value = ctDto.TrangThai;
            cmd.Parameters["@Id"].Value = ctDto.Id;
            cmd.ExecuteNonQuery();
            // B5: Dong ket noi CSDL
            cn.Close();
        }
        public ChiTietDto getPhongBySoPhong (int soPhong)
        {
            ChiTietDto ctDto = new ChiTietDto();
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Select TOP 1 * From ChiTietDatPhong Where SoPhong = ? ORDER BY ID DESC";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@SoPhong", OleDbType.Integer);
            cmd.Parameters["@SoPhong"].Value = soPhong;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                ctDto.Id = (int)dr["ID"];
                ctDto.SoPhong = (int)dr["SoPhong"];
                ctDto.Ten = (string)dr["Ten"];
                ctDto.GioVao = (DateTime)dr["GioVao"];
                ctDto.GioRa = (DateTime)dr["GioRa"];
                ctDto.TrangThai = (int)dr["TrangThai"];
                ctDto.TienGio = (double)dr["TienGio"];
                ctDto.PhuThu = (double)dr["PhuThu"];
                ctDto.GhiChu = (string)dr["GhiChu"];
                ctDto.TongTien = (double)dr["TongTien"];
                ctDto.Vip = (int)dr["VIP"];
                ctDto.LoaiPhong = (int)dr["LoaiPhong"];
                ctDto.GiaThuongLuong = (double)dr["GiaThuongLuong"];
            }
            // B5: Dong ket noi CSDL
            dr.Close();
            cn.Close();
            return ctDto;

        }
        

        public DataSet getAllTemp()
        {
            ChiTietDto ctDto = new ChiTietDto();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "SELECT SoPhong, TrangThai FROM  ChiTietDatPhong WHERE ID IN (SELECT MAX( ID ) FROM  ChiTietDatPhong GROUP BY SoPhong)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable table1 = new DataTable("ChiTietPhong");
            table1.Columns.Add("STT");
            table1.Columns.Add("SoPhong");
            table1.Columns.Add("TrangThai");
            int count = 0;
            while (dr.Read())
            {
                //ctDto.Id = (int)dr["ID"];
                //ctDto.SoPhong = (int)dr["SoPhong"];
                //ctDto.Ten = (string)dr["Ten"];
                //ctDto.GioVao = (DateTime)dr["GioVao"];
                //ctDto.TrangThai = (int)dr["TrangThai"];

                table1.Rows.Add(++count, (int)dr["SoPhong"], (int)dr["TrangThai"]);

            }
            // B5: Dong ket noi CSDL
            dr.Close();
            cn.Close();

            DataSet set = new DataSet("ChiTietPhong");
            set.Tables.Add(table1);

            return set;
        }
        public DataSet getAll()
        {
            ChiTietDto ctDto = new ChiTietDto();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From ChiTietDatPhong";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable table1 = new DataTable("ChiTietPhong");
            table1.Columns.Add("STT");
            table1.Columns.Add("So Phong");
            int count = 0;
            while (dr.Read())
            {
                //ctDto.Id = (int)dr["ID"];
                //ctDto.SoPhong = (int)dr["SoPhong"];
                //ctDto.Ten = (string)dr["Ten"];
                //ctDto.GioVao = (DateTime)dr["GioVao"];
                //ctDto.TrangThai = (int)dr["TrangThai"];
                
                table1.Rows.Add(++count, (int)dr["SoPhong"]);

            }
            // B5: Dong ket noi CSDL
            dr.Close();
            cn.Close();

            DataSet set = new DataSet("ChiTietPhong");
            set.Tables.Add(table1);

            return set;
        }
        public DataSet getAllNeed()
        {
            ChiTietDto ctDto = new ChiTietDto();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            DateTime temp = DateTime.Now;
            DateTime gioVao = new DateTime();
            DateTime gioChuan = new DateTime();
            gioChuan = Convert.ToDateTime("01 / 01 / 2000 00:00:00");
            if (temp.Hour >= 18 && temp.Minute >= 30)
            {
                gioVao = Convert.ToDateTime(temp.Month + " / " + temp.Day + " / " + temp.Year + " 06:30:00");
            } else
            {                
                temp = temp.AddDays(-1);
                gioVao = Convert.ToDateTime(temp.Month + " / " + temp.Day + " / " + temp.Year + " 18:30:00");
            }
            
            strSQL = "Select * From ChiTietDatPhong Where GioVao >= ? or GioRa = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@GioVao", OleDbType.Date);
            cmd.Parameters.Add("@GioRa", OleDbType.Date);
            cmd.Parameters["@GioVao"].Value = gioVao;
            cmd.Parameters["@GioRa"].Value = gioChuan;

            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable table1 = new DataTable("ChiTietPhong");
            table1.Columns.Add("STT");
            table1.Columns.Add("Số phòng");
            table1.Columns.Add("Tên");
            table1.Columns.Add("Giờ Vào");
            table1.Columns.Add("Giờ Ra");
            table1.Columns.Add("Phụ Thu");
            table1.Columns.Add("Tổng tiền");
            table1.Columns.Add("Loại Phòng");
            int count = 0;
            while (dr.Read())
            {
                //ctDto.Id = (int)dr["ID"];
                //ctDto.SoPhong = (int)dr["SoPhong"];
                //ctDto.Ten = (string)dr["Ten"];"
                //ctDto.GioVao = (DateTime)dr["GioVao"];
                //ctDto.TrangThai = (int)dr["TrangThai"];
                String lp = "";
                if((int)dr["LoaiPhong"] == 1)
                {
                    lp = "Qua Đêm";
                } 
                if ((DateTime)dr["GioRa"] == gioChuan)
                {
                    table1.Rows.Add(++count, (int)dr["SoPhong"], (string)dr["Ten"], (DateTime)dr["GioVao"], "", (Double)dr["PhuThu"], (Double)dr["TongTien"], lp);
                } else
                {
                    table1.Rows.Add(++count, (int)dr["SoPhong"], (string)dr["Ten"], (DateTime)dr["GioVao"], (DateTime)dr["GioRa"], (Double)dr["PhuThu"], (Double)dr["TongTien"], lp);
                }               

            }
            // B5: Dong ket noi CSDL
            dr.Close();
            cn.Close();

            DataSet set = new DataSet("ChiTietPhong");
            set.Tables.Add(table1);

            return set;
        }
        public DataSet getNotCharge()
        {
            ChiTietDto ctDto = new ChiTietDto();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;

            strSQL = "Select * From ChiTietDatPhong Where TongTien = 0";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable table1 = new DataTable("ChiTietPhong");
            table1.Columns.Add("STT");
            table1.Columns.Add("Số phòng");
            table1.Columns.Add("Tên");
            table1.Columns.Add("Giờ vào");
            table1.Columns.Add("Tổng tiền");
            table1.Columns.Add("Loại phòng");
            table1.Columns.Add("Giá thương lượng");
            int count = 0;
            while (dr.Read())
            {
                //ctDto.Id = (int)dr["ID"];
                //ctDto.SoPhong = (int)dr["SoPhong"];
                //ctDto.Ten = (string)dr["Ten"];"
                //ctDto.GioVao = (DateTime)dr["GioVao"];
                //ctDto.TrangThai = (int)dr["TrangThai"];
                String lp = "";
                if ((int)dr["LoaiPhong"] == 1)
                {
                    lp = "Qua Đêm";
                }
                else if ((int)dr["LoaiPhong"] == 2)
                {
                    lp = "Dài hạn";
                }

                table1.Rows.Add(++count, (int)dr["SoPhong"], (string)dr["Ten"], (DateTime)dr["GioVao"], (Double)dr["TongTien"], lp, (Double)dr["GiaThuongLuong"]);

            }
            // B5: Dong ket noi CSDL
            dr.Close();
            cn.Close();

            DataSet set = new DataSet("ChiTietPhong");
            set.Tables.Add(table1);

            return set;
        }
        public DataSet getDependTime(DateTime timeFrom, DateTime timeTo)
        {
            ChiTietDto ctDto = new ChiTietDto();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;


            strSQL = "Select * From ChiTietDatPhong Where GioRa >= @date1 and GioRa <= @date2";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@date1", OleDbType.Date);
            cmd.Parameters.Add("@date2", OleDbType.Date);
            cmd.Parameters["@date1"].Value = timeFrom;
            cmd.Parameters["@date2"].Value = timeTo;


            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable table1 = new DataTable("ChiTietPhong");
            table1.Columns.Add("STT");
            table1.Columns.Add("Số phòng");
            table1.Columns.Add("Tên");
            table1.Columns.Add("Giờ vào");
            table1.Columns.Add("Giờ ra");
            table1.Columns.Add("Phụ thu");
            table1.Columns.Add("Tổng tiền");
            table1.Columns.Add("Loại phòng");
            table1.Columns.Add("Giá thương lượng");
            int count = 0;
            while (dr.Read())
            {
                //ctDto.Id = (int)dr["ID"];
                //ctDto.SoPhong = (int)dr["SoPhong"];
                //ctDto.Ten = (string)dr["Ten"];"
                //ctDto.GioVao = (DateTime)dr["GioVao"];
                //ctDto.TrangThai = (int)dr["TrangThai"];
                String lp = "";
                if ((int)dr["LoaiPhong"] == 1)
                {
                    lp = "Qua Đêm";
                }
                else if ((int)dr["LoaiPhong"] == 2)
                {
                    lp = "Dài hạn";
                }

                table1.Rows.Add(++count, (int)dr["SoPhong"], (string)dr["Ten"], (DateTime)dr["GioVao"], (DateTime)dr["GioRa"], (Double)dr["PhuThu"], (Double)dr["TongTien"], lp, (Double)dr["GiaThuongLuong"]);
               

            }
            // B5: Dong ket noi CSDL
            dr.Close();
            cn.Close();

            DataSet set = new DataSet("ChiTietPhong");
            set.Tables.Add(table1);

            return set;
        }
        public DataSet getAllTime()
        {
            ChiTietDto ctDto = new ChiTietDto();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            DateTime temp = DateTime.Now;
            DateTime gioVao = new DateTime();
            DateTime gioChuan = new DateTime();
            gioChuan = Convert.ToDateTime("01 / 01 / 2000 00:00:00");
            if (temp.Hour >= 18 && temp.Minute >= 30)
            {
                gioVao = Convert.ToDateTime(temp.Month + " / " + temp.Day + " / " + temp.Year + " 6:30:00");
            }
            else
            {
                temp = temp.AddDays(-1);
                gioVao = Convert.ToDateTime(temp.Month + " / " + temp.Day + " / " + temp.Year + " 18:30:00");
            }

            strSQL = "Select * From ChiTietDatPhong Where GioVao >= ? or (GioRa = ? and LoaiPhong = 0)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@GioVao", OleDbType.Date);
            cmd.Parameters.Add("@GioRa", OleDbType.Date);
            cmd.Parameters["@GioVao"].Value = gioVao;
            cmd.Parameters["@GioRa"].Value = gioChuan;

            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable table1 = new DataTable("ChiTietPhong");
            table1.Columns.Add("STT");
            table1.Columns.Add("Số phòng");
            table1.Columns.Add("Tên");
            table1.Columns.Add("Giờ Vào");
            table1.Columns.Add("Giờ Ra");
            table1.Columns.Add("Phụ Thu");
            table1.Columns.Add("Tổng tiền");
            table1.Columns.Add("Loại Phòng");
            int count = 0;
            while (dr.Read())
            {
                //ctDto.Id = (int)dr["ID"];
                //ctDto.SoPhong = (int)dr["SoPhong"];
                //ctDto.Ten = (string)dr["Ten"];
                //ctDto.GioVao = (DateTime)dr["GioVao"];
                //ctDto.TrangThai = (int)dr["TrangThai"];

                String lp = "";
                if ((int)dr["LoaiPhong"] == 1)
                {
                    lp = "Qua Đêm";
                }
                if ((DateTime)dr["GioRa"] == gioChuan)
                {
                    table1.Rows.Add(++count, (int)dr["SoPhong"], (string)dr["Ten"], (DateTime)dr["GioVao"], "", (Double)dr["PhuThu"], (Double)dr["TongTien"], lp);
                }
                else
                {
                    table1.Rows.Add(++count, (int)dr["SoPhong"], (string)dr["Ten"], (DateTime)dr["GioVao"], (DateTime)dr["GioRa"], (Double)dr["PhuThu"], (Double)dr["TongTien"], lp);
                }

            }
            // B5: Dong ket noi CSDL
            dr.Close();
            cn.Close();

            DataSet set = new DataSet("ChiTietPhong");
            set.Tables.Add(table1);

            return set;
        }
    }
}
