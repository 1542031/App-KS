using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.DAO;
using KS.DTO;

namespace KS.BUS
{
    public class ChiTietBus
    {
        public void Them(ChiTietDto ctDto)
        {
            ChiTietDao ctDao = new ChiTietDao();
            ctDao.Them(ctDto);
        }
        public void Sua(ChiTietDto ctDto)
        {
            // Kiem tra Business Rule neu co
            ChiTietDao ctDao = new ChiTietDao();
            ctDao.Sua(ctDto);
        }
        public void UpdateByID(ChiTietDto ctDto)
        {
            // Kiem tra Business Rule neu co
            ChiTietDao ctDao = new ChiTietDao();
            ctDao.UpdateByID(ctDto);
        }
    }
}
