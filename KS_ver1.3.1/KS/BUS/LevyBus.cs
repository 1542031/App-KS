using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.DAO;
using KS.DTO;

namespace KS.BUS
{
    class LevyBus
    {
        public void Them(LevyDto lvDto)
        {
            LevyDao lvDao = new LevyDao();
            lvDao.Them(lvDto);
        }

    }
}
