using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using KS.DTO;

namespace KS.DAO
{
    class LevyDao
    {
        public void Them(LevyDto lvDto)
        {
            OleDbConnection cn;
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Insert into LevyTime(GioThuTien,SoTien) values (?, ?)" +
            "";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@GioThuTien", OleDbType.Date);
            cmd.Parameters["@GioThuTien"].Value = lvDto.GioThuTien;
            cmd.Parameters.Add("@SoTien", OleDbType.Double);
            cmd.Parameters["@SoTien"].Value = lvDto.SoTien;
            cmd.ExecuteNonQuery();
            strSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(strSQL, cn);
            lvDto.Id = (int)cmd.ExecuteScalar();
            // B5: Dong ket noi CSDL
            cn.Close();
        }
        public LevyDto getPrevTime()
        {
            LevyDto lvDto = new LevyDto();
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Select TOP 1 * From LevyTime ORDER BY ID DESC";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lvDto.Id = (int)dr["ID"];
                lvDto.GioThuTien = (DateTime)dr["GioThuTien"];
                lvDto.SoTien = (double)dr["SoTien"];
            }
            // B5: Dong ket noi CSDL
            dr.Close();
            cn.Close();
            return lvDto;

        }
    }
}
