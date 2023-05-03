using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telefonRehberi
{
    public class aramaIslemi : MevcutRehber
    {
        public static void Arama()
        {
            Console.WriteLine("Arama yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("*****************************************");
            Console.WriteLine("İsim ve soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Numaraya göre arama yapmak için: (2)");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("İsim ve soyisim giriniz:");
                string adsoyad = Console.ReadLine();
                foreach (var item in telefonRehberim)
                {
                    if (adsoyad == item.isim || adsoyad == item.soyisim)
                    {
                        Console.WriteLine("İsim      :" + item.isim);
                        Console.WriteLine("Soyisim   :" + item.soyisim);
                        Console.WriteLine("Numara    :" + item.numara);
                        Console.WriteLine("----");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi bulunamadı.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen numara giriniz: ");
                string number = Console.ReadLine();
                foreach (var item in telefonRehberim)
                {
                    if (number == item.numara)
                    {

                        Console.WriteLine("İsim      :" + item.isim);
                        Console.WriteLine("Soyisim   :" + item.soyisim);
                        Console.WriteLine("Numara    :" + item.numara);
                        Console.WriteLine("----");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi bulunamadı.");
                        break;
                    }
                }
            }
        }
    }
}