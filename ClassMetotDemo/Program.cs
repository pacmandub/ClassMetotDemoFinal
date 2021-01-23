using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Osman";
            musteri1.Soyad = "Kurt";
            musteri1.Meslek = "Galerici";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Kemal";
            musteri2.Soyad = "Nalcı";
            musteri2.Meslek = "Kuyumcu";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Ahmet";
            musteri3.Soyad = "Poyraz";
            musteri3.Meslek = "Nakliyeci";



            // metotlar

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteri = new MusteriManager();
            Console.WriteLine("Lütfen bir seçenek giriniz. \n 1-Ekle\n 2-Listele \n 3-Sil");
            islem:
            int cozum = Convert.ToInt32(Console.ReadLine());
           

            if (cozum==1)
            {              
                musteri.Add(musteri1);
                musteri.Add(musteri2);
                musteri.Add(musteri3);
                goto islem;
            }
            else if (cozum==2)
            {
                musteri.Listele(musteri1);
                musteri.Listele(musteri2);
                musteri.Listele(musteri3);
                goto islem;
            }
            else if (cozum==3)
            {
                musteri.Sil(musteri1);
                musteri.Sil(musteri2);
                musteri.Sil(musteri3);
                goto islem;
            }
            else
            {
                Console.WriteLine("yanlış bir komut girdiniz lütfen tekrar giriniz.");
                goto islem;
            }
            
            
        }
    }
}
