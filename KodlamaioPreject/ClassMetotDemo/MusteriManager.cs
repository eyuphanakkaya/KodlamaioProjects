using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklenmiştir="+musteri.Ad+" "+musteri.Soyad);
        }
        public void List(Musteri musteri,Musteri musteri1,Musteri musteri2)
        {
            Console.WriteLine("Müşteri Listesi="+" "+musteri.Id+"id="+musteri1.Id+" id="+musteri2.Id);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Silindi="+" "+musteri.Id);
        }

    }
}
