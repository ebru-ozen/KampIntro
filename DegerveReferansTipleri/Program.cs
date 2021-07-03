using System;

namespace DegerveReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? 30


            
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] ?? 999
            // Değer tipler; int,decimal,float,double,bool gibi sayısal veri tipleridir. Referans veri tipleri ise array,class,interface gibi 
            // veri tipleridir. Değer veri tipi değer tutarken; referans veri tipi adres tutar yani burada array sayilar1 direk sayilar2 arrayine
            // eşitlenmez. Array sayilar1 in bellekte oluşuan adresi array sayilar2 nin bellekte oluşan adresine eşitlenir bu yüzden array sayilar2
            // de yapılan her değişiklik array sayilar 1 de değiştirir. sayilar1 arraynin eski adreside .NET in garbage collector ü tarafından silinir.
            
            









        }
    }
}
