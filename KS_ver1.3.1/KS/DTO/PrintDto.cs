using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS.DTO
{
    class PrintDto
    {
        private int id;
        private DateTime printTime;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime PrintTime
        {
            get { return printTime; }
            set { printTime = value; }
        }

        public PrintDto()
        {
            printTime = new DateTime(1, 1, 1, 1, 1, 1);
        }
    }
}
