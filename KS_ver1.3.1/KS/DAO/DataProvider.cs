using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace KS.DAO
{
    class DataProvider
    {
        public static OleDbConnection ConnectionData()
        {
            string cnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=QuanLyKhachSan.accdb;";
            OleDbConnection cn = new OleDbConnection(cnStr);
            cn.Open();
            return cn;
        }
    }
}
