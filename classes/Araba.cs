using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    public class Araba
    {
        public int KapiSayisi;
        public int ArabaSayisi;
        public string ArabaModeli;

        public void MotoriCalistir()
        {
            Console.WriteLine("Motor çalıştırılıyor...");
        }
        public void KapilariAc()
        {
            Console.WriteLine("Kapilar açılıyor...");
        }
    }
}
