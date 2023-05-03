using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telefonRehberi
{
    public class MevcutRehber
    {
        public static List<Rehber> _telefonRehberim;

        static MevcutRehber()
        {
            _telefonRehberim = new List<Rehber>();
            {
                new Rehber { isim = "XXX", soyisim = "xxx", numara = "11111" };
                new Rehber { isim = "YYY", soyisim = "yyy", numara = "22222" };
                new Rehber { isim = "AAA", soyisim = "aaa", numara = "33333" };
                new Rehber { isim = "BBB", soyisim = "bbb", numara = "44444" };
                new Rehber { isim = "CCC", soyisim = "ccc", numara = "55555" };
            }

        }
        public static List<Rehber> telefonRehberim
        {
            get { return _telefonRehberim; }
        }
        public static void rehberiYazdir()
        {
            foreach (var item in telefonRehberim)
            {
                Console.WriteLine(item.isim + " " + item.soyisim + " " + item.numara);
            }
        }
    }
}