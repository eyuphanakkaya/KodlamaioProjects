using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() 
            {
                Id = 1,
                Ad = "Selin",
                Soyad = "Ol",
                Yas = 24,
                Meslek = "Oğretmen"
            };

            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                Ad = "Selen",
                Soyad = "Olun",
                Yas = 25,
                Meslek = "Oğrenci"
            };

            Musteri musteri3 = new Musteri()
            {
                Id = 3,
                Ad = "Oğul",
                Soyad = "Irmak",
                Yas = 22,
                Meslek = "Zengin"
            };


            Musteri musteri4 = new Musteri()
            {
                Id = 4,
                Ad = "Pelin",
                Soyad = "Uğurlu",
                Yas = 27,
                Meslek = "Mühendis"
            };


            Musteri[] musteri = new Musteri[] {musteri1, musteri2, musteri3, musteri4 };

            foreach (var musteriler in musteri)
            {
                Console.WriteLine(musteriler.Id+"- "+ musteriler.Ad+" "+musteriler.Soyad+"="+musteriler.Meslek);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.List(musteri4,musteri3,musteri1);
            musteriManager.Sil(musteri1);






            Console.ReadKey();

        }
    }
}
