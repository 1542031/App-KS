using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS.BUS
{
    public class SomeFunctionBus
    {
        public double TienGio(int days, int hours)
        {
            double tienGio = 0;

            //if (hours >= 16)
            //{
            //    tienGio = (uint)(days + 1) * 240000;
            //    hours = 0;
            //}
            //else
            //{
            //    tienGio = (uint)days * 240000;
            //}
            
            if (hours == 0) {
                if (days != 0)
                {
                    return tienGio;
                }
                else {
                    tienGio += 60000;
                }
            }else if (hours < 2)
            {
                tienGio += 60000;
            }
            else if (hours < 6)
            {
                tienGio += 60000 + ((uint)hours - 1) * 20000;
            }
            else if (hours < 7)
            {
                tienGio += 150000;
            }
            else if (hours < 9)
            {
                tienGio += 160000;
            }
            else if (hours < 11)
            {
                tienGio += 180000;
            }
            else 
            {
                tienGio += 200000;
            }
   
            return tienGio;
        }
        public double TienGioVIP(int days, int hours)
        {
            double tienGio = 0;
            //if (hours >= 16)
            //{
            //    tienGio = (uint)(days + 1) * 300000;
            //    hours = 0;
            //}
            //else
            //{
            //    tienGio = (uint)days * 300000;
            //}
            if (hours == 0)
            {
                if (days != 0)
                {
                    return tienGio;
                }
                else
                {
                    tienGio += 100000;
                }
            } else if (hours < 2)
            {
                tienGio += 100000;
            }
            else if (hours < 9)
            {
                tienGio += 100000 + ((uint)hours - 1) * 20000;
            }

            else if (hours < 11)
            {
                tienGio += 250000;
            }
            else
            {
                tienGio += 280000;
            }
            return tienGio;
        }
        public double PhuThuQD(DateTime gioVao, DateTime gioRa)
        {
            double tienQuaGio = 0;
            int gioRaTemp = Convert.ToInt32(gioRa.ToString("HH"));
            int gioVaoTemp = Convert.ToInt32(gioVao.ToString("HH"));
            if (gioRaTemp < 12) {
                string gioRaString = gioRa.ToString("MM") + "/" + gioRa.ToString("dd") + "/" + gioRa.ToString("yyyy") + " 12:00:00";
                gioRa = Convert.ToDateTime(gioRaString);
            }
            if (gioVaoTemp > 19)
            {
                string gioVaoString = gioVao.ToString("MM") + "/" + gioVao.ToString("dd") + "/" + gioVao.ToString("yyyy") + " 20:00:00";
                gioVao = Convert.ToDateTime(gioVaoString);
            }
            TimeSpan interval = gioRa.Subtract(gioVao);


            int soGio = interval.Hours;
            int soNgay = interval.Days;
            int soPhut = interval.Minutes;
            if (soPhut > 12)
            {
                soGio++;
            }
            if (soNgay == 1)
            {
                soGio = soGio + 24;
            }
            if (soGio > 16) { 
                tienQuaGio = (soGio - 16)*20000;
            }
            return tienQuaGio;
        }
    }
}
