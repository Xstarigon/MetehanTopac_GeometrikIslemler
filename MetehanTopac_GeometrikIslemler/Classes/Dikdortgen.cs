using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetehanTopac_GeometrikIslemler.Interfaces;

namespace MetehanTopac_GeometrikIslemler.Classes
{
    class Dikdortgen : IDortgen
    {
        public double KisaKenar { get; set; }
        public double UzunKenar { get; set; }

        public double AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

        public double CevreHesapla()
        {
            return 2 * KisaKenar + 2 * UzunKenar;
        }
    }
}
