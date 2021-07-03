using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.Adi = "elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";
            product1.Id = 12345;


            Products product2 = new Products();
            product2.Adi = "karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";
            product2.Id = 12346;

            Products[] products = new Products[] { product1, product2 };

            // var kısmı aynen kalsa da olur çünkü arka planda değişkeni products yapıyor.
            foreach (Products product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Id);
                Console.WriteLine("************************");

            }

            Console.WriteLine("--------------METOTLAR----------------");

            //instance-örnek
            // encapsulatıon
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);



        }
    }
}
