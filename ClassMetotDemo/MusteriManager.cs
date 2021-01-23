using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +"-" + musteri.Ad + "-"+ musteri.Soyad + "-"+ musteri.Meslek);
            Console.WriteLine("\n Musteriler eklendi");
            Console.WriteLine("** \n");
        }
        public void Listele(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + "\n" + musteri.Ad + "\n" + musteri.Soyad +"\n" + musteri.Meslek);
            Console.WriteLine("\n Musteriler listelendi.");
            Console.WriteLine("** \n");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteriler silindi!!!!!");
            Console.WriteLine("** \n");
        }

    }
}
