using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Urunad = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Çok iyi elma";

            Urun urun2 = new Urun();
            urun2.Urunad = "Çilek";
            urun2.Fiyat = 18;
            urun2.Aciklama = "Çok iyi çilek";


            Urun[] uruns = new Urun[] {urun1,urun2 };


            foreach (Urun urun in uruns)
            {
                Console.WriteLine(urun.Urunad+":"+urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("------------Metotlar--------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);


            int numara1;
            int numara2 = 30;
            Console.WriteLine(Topla(out numara1,numara2));
            Console.WriteLine(numara1);

            Console.ReadKey();
        }


        static int Topla(out int numara1,int numara2)
        {
            numara1 = 25;
            return numara1 + numara2;
        }
    }
}
