using System;

namespace telefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi  Seçiniz!");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Telefon Numarası Kaydet");
            Console.WriteLine("(2) Telefon Numarası Sil");
            Console.WriteLine("(3) Telefon Numarası Güncelle");
            Console.WriteLine("(4) Telefon Numarası Listele");
            Console.WriteLine("(5) Rehberde Arama");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {

                case 1:
                    kaydetmeIslemi.Kaydet();
                    break;
                case 2:
                    silmeIslemi.Silme();
                    break;
                case 3:
                    guncellemeIslemi.Guncelleme();
                    break;
                case 4:
                    listelemeIslemi.Listeleme();
                    break;
                case 5:
                    aramaIslemi.Arama();
                    break;

            }
        }
    }
}
