using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetehanTopac_GeometrikIslemler.Interfaces;

namespace MetehanTopac_GeometrikIslemler.Classes
{
    class EskenarUcgen : IUcgen
    {
        public double TabanKenar { get; set; }

        public double AlanHesapla()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(TabanKenar, 2);
        }

        public double CevreHesapla()
        {
            return TabanKenar * 3;
        }
    }
}
