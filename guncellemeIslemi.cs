using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telefonRehberi
{
    public class guncellemeIslemi : MevcutRehber
    {
        public static void Guncelleme()
        {
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını veya soyadını giriniz:");
            string input = Console.ReadLine();

            foreach (var item in telefonRehberim.ToList())
            {
                if (input == item.isim || input == item.soyisim)
                {
                    Console.WriteLine("Lütfen yeni numara giriniz: ");
                    string number = Console.ReadLine();
                    item.numara = number;
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız kişi bulunamadı. Lütfen seçim yapınız:");
                    Console.WriteLine("Güncellemeyi sonlandırmak için: (1)");
                    Console.WriteLine("Yeniden denemek için: (2)");
                    int input2 = Convert.ToInt32(Console.ReadLine());

                    if (input2 == 1)
                    {
                        Console.WriteLine("İşlem sonlandırıldı.");
                    }
                    else
                    {
                        guncellemeIslemi.Guncelleme();

                    }

                }

            }

        }
    }
}