using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telefonRehberi
{
    public class kaydetmeIslemi : MevcutRehber
    {
        public static void Kaydet()
        {
            Console.WriteLine("Lütfen isim giriniz: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz: ");
            string soyad = Console.ReadLine();
            Console.WriteLine("Lütfen numaranızı giriniz: ");
            string no = Console.ReadLine();

            Rehber kisi = new Rehber();
            kisi.isim = ad;
            kisi.soyisim = soyad;
            kisi.numara = no;
            MevcutRehber._telefonRehberim.Add(kisi);
        }
    }
}