using System;

namespace kampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type safety = tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogernciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYApmısMı = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");


            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonunu göster");
            }
            else
            {
                Console.WriteLine("Eşittir butonu göster");
            }


            if (sistemeGirisYApmısMı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
