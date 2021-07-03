using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string AdEtiketi = "ebru";
            Console.WriteLine(AdEtiketi);
            bool AdDogruMU = true;
            Console.WriteLine(AdDogruMU);
            double KiloEtiketi = 48.5;
            Console.WriteLine(KiloEtiketi);
            int YasEtiketi = 20;
            Console.WriteLine(YasEtiketi);
            if (AdDogruMU == false)
            {
                Console.WriteLine("ad yanlıs");
            }
            else
            {
                Console.WriteLine("ad dogru");

            }
            double DolarDun = 9.45;
            double DolarBugun = 9.49;
            if (DolarDun > DolarBugun)
            {
                Console.WriteLine("Dolar düşmüş.");
            }
            else if (DolarDun == DolarBugun)
            {
                Console.WriteLine("Dolar aynı kalmış.");
            }
            else
            {
                Console.WriteLine("Dolar yükselmiş.");
            }

            string ad = "ebru beyza özen";
            Console.WriteLine(ad);
            int x = 9;
            if (x == 5)
            {
                Console.WriteLine("x eşittir 5");
            }
            else if (x != 5)
            {
                Console.WriteLine("x eşit değildir");
            
            }

              
   






            Console.ReadLine();
        }
    }
}
