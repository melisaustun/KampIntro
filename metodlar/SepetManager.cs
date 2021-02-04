using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) //class
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        { //classdeğil
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunAdi);
        }
    }
}