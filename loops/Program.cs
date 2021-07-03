using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // for döngüsünü çalıştırmak için for yaz ve 2 kez tab tuşuna bas. Karşına çıkan iskeleti istediğin gibi düzenle.
            for (int i = 0; i <= 10; i=i+2)
            {
                Console.WriteLine(i + " yazdırıldı.");
            }
            // array oluşturma
            string[] kurslar = new string[] { "gitar kursu", "keman kursu","piyano kursu","saz kursu","klavye kursu" };

            for (int i = 0; i<3; i++)
			{
                Console.WriteLine(kurslar[i]);
			}
            Console.WriteLine("***********************************");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            // foreach döngüsü
            foreach ( string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }






            Console.ReadLine();
        }
    }
}
