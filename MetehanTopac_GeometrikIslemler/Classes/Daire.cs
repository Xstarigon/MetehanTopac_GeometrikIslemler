using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetehanTopac_GeometrikIslemler.Classes
{
    class Daire
    {
        public double Radius { get; set; }

        public double CevreHesapla()
        {
            return 2 * Math.PI * Radius;
        }

        public double AlanHesapla()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
