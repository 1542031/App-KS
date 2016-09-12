using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using KS.DTO;

namespace KS.DAO
{
    class PrintDao
    {
        public void Them(PrintDto ptDto)
        {
            OleDbConnection cn;
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Insert into PrintTime(PrintTime) values (?)" +
            "";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@PrintTime", OleDbType.Date);
            cmd.Parameters["@PrintTime"].Value = ptDto.PrintTime;

            cmd.ExecuteNonQuery();
            strSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(strSQL, cn);
            ptDto.Id = (int)cmd.ExecuteScalar();
            // B5: Dong ket noi CSDL
            cn.Close();
        }
        public int getNumber()
        {
            PrintDto ctDto = new PrintDto();
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            DateTime temp = new DateTime();
            temp = DateTime.Now.Date;
            string strSQL;
            strSQL = "Select count(*) From PrintTime Where PrintTime = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@PrintTime", OleDbType.Date);
            cmd.Parameters["@PrintTime"].Value = temp;
            int countNumber = (int)cmd.ExecuteScalar();


            // B5: Dong ket noi CSDL

            cn.Close();
            return countNumber;

        }
    }
}
