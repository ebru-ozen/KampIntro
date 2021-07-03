using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    class DortIslem
    {
        // Topla(2,3)
        public void Topla(int number1, int number2)
        {
            int toplam = number1 + number2;
            Console.WriteLine("Sonuc : " + toplam);

        }
        public void Cıkarma(int number1,int numer2)
        {
            int fark = number1 - number2;
            Console.WriteLine("Sonuc : " + fark);

        }

        public void Carpma(int number1, int number2)
        {
            int carpım = number1 * number2;
            Console.WriteLine("Sonuc : " + carpım);

        }

        public void Bolme(int number1, int number2)
        {
            int bolum = number1 / number2;
            Console.WriteLine("Sonuc : " + bolum);
        }

    }
}
