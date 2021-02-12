using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Progreamlamaya başlagıç için temel kurs";
            string kurs3 = "Java";
            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Progreamlamaya başlagıç için temel kurs", "Java" ,"Python","C++"};
               
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }    
        }
    }
}
