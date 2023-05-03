using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telefonRehberi
{
    public class listelemeIslemi : MevcutRehber
    {
        public static void Listeleme()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*********************************");
            foreach (var item in telefonRehberim)
            {
                Console.WriteLine("İsim     :" + item.isim);
                Console.WriteLine("Soyisim  :" + item.soyisim);
                Console.WriteLine("Numara   :" + item.numara);
                Console.WriteLine("----");
            }
        }
    }
}