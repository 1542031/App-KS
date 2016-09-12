using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.DAO;
using KS.DTO;

namespace KS.BUS
{
    class PrintBus
    {
        public void Them(PrintDto ptDto)
        {
            PrintDao ptDao = new PrintDao();
            ptDao.Them(ptDto);
        }
    }
}
