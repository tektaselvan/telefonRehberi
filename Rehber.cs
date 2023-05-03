using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telefonRehberi
{
    public class Rehber
    {
        private string Isim;
        private string Soyisim;
        private string Numara;

        public string isim { get => Isim; set => Isim = value; }
        public string soyisim { get => Soyisim; set => Soyisim = value; }
        public string numara { get => Numara; set => Numara = value; }

        public Rehber(string isim, string soyisim, string numara)
        {
            Isim = isim;
            Soyisim = soyisim;
            Numara = numara;
        }
        public Rehber()
        {

        }
    }
}