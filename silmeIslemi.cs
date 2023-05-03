using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telefonRehberi
{
    public class silmeIslemi : MevcutRehber
    {
        public static void Silme()
        {
            Console.WriteLine("Lütfen silmek istediğiniz kişinin adını veya soyadını giriniz:");
            string input = Console.ReadLine();
            foreach (var item in telefonRehberim.ToList())
            {
                Console.WriteLine(item.isim + " " + item.soyisim + "isimli kişi silinecek, onaylıyor musunuz? (e/h)");
                string input1 = Console.ReadLine();
                if (input == item.isim || input == item.soyisim)
                {
                    if (input1 == "e")
                    {
                        telefonRehberim.Remove(item);
                    }
                    else
                    {
                        Console.WriteLine("Çıkış yapıldı!");
                        break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
                    Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                    Console.WriteLine("* Yeniden denemek için (2)");
                    int input2 = Convert.ToInt32(Console.ReadLine());

                    if (input2 == 1)
                    {
                        Console.WriteLine("İşlem sonlandırıldı.");
                        break;
                    }
                    else
                    {
                        silmeIslemi.Silme();
                    }
                    break;
                }

            }


        }
    }
}