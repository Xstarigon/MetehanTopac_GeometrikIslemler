using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetehanTopac_GeometrikIslemler.Interfaces
{
    interface IUcgen
    {
        public double TabanKenar { get; set; }
        public double AlanHesapla();
        public double CevreHesapla();
    }
}
