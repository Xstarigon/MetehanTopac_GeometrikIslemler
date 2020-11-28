using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetehanTopac_GeometrikIslemler.Interfaces;

namespace MetehanTopac_GeometrikIslemler.Classes
{
    class Kare : IDortgen
    {
        public double UzunKenar { get; set; }

        public double AlanHesapla()
        {
            return UzunKenar * UzunKenar;
        }

        public double CevreHesapla()
        {
            return 4 * UzunKenar;
        }
    }
}
