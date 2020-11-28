using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetehanTopac_GeometrikIslemler.Interfaces;

namespace MetehanTopac_GeometrikIslemler.Classes
{
    class DikUcgen : IUcgen
    {
        public double TabanKenar { get; set; }

        public double Yukseklik;
        private double _hypotenuse;
        public double AlanHesapla()
        {
            return TabanKenar * Yukseklik / 2;
        }

        public double CevreHesapla()
        {
            _hypotenuse = Math.Sqrt(Math.Pow(TabanKenar, 2) + Math.Pow(Yukseklik, 2));
            return Yukseklik + TabanKenar + _hypotenuse;
        }
    }
}
