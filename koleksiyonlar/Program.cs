using System;
using System.Collections.Generic;

namespace koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[5] {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            isimler2.Add("İlker");
            foreach (var isim in isimler2)
            {
                Console.WriteLine(isim);
            }



        }
    }
}
