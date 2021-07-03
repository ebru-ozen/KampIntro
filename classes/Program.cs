using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.KapiSayisi = 4;
            araba1.ArabaSayisi = 2;
            araba1.ArabaModeli = "Ford";
            araba1.MotoriCalistir();
            araba1.KapilariAc();

            Console.WriteLine("Arabanin kapi sayisi: " + araba1.KapiSayisi);
            Console.WriteLine("Araba sayisi: " + araba1.ArabaSayisi);
            Console.WriteLine("Araba modeli: " + araba1.ArabaModeli);

            Console.WriteLine("***********************************************");

            Customer customer1 = new Customer();
            customer1.Custom_age = 19;
            customer1.Custom_name = "enes";
            customer1.Custom_profession = "Covid tester";
            customer1.Custom_wage = 3000;
            customer1.Custome_delaying();
            customer1.Custome_delaying();
            customer1.Custome_paying();
   

            Console.WriteLine("customer's name: " + customer1.Custom_name);
            Console.WriteLine("customer's age: " + customer1.Custom_age);
            Console.WriteLine("customer's proffession: " + customer1.Custom_profession);
            Console.WriteLine("customer's wage: " + customer1.Custom_wage);


        }
        // Engin Demiroğ'un anlatımına göre de class ı main page de böyle kuruyor.
        // class yaz, 2 kez tab tuşu yap, class'a isim ver.
        // süslü parantezlerin içine prop yaz 2 kez tab tuşuna bas aşağıdaki gibi şöyle bir public int MyProperty { get; set; }
        // bir iskelet çıksın.
        class kurs
        {
            public int MyProperty { get; set; }


        }
    }
}
