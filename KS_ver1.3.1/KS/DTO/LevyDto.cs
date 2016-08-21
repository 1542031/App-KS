using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS.DTO
{
    class LevyDto
    {
        private int id;
        private DateTime gioThuTien;
        private double soTien;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime GioThuTien
        {
            get { return gioThuTien; }
            set { gioThuTien = value; }
        }
        public double SoTien
        {
            get { return soTien; }
            set { soTien = value; }
        }
        public LevyDto()
        {
            gioThuTien = new DateTime(1, 1, 1, 1, 1, 1);
            soTien = 0;
        }
    }
}
