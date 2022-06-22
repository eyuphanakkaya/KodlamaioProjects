using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>
            {"Eyüp","Han","Selim","Bulut" };
            isimler.Add("Irmak");
           
            foreach (var isims in isimler)
            {
                Console.WriteLine(isims);
            }


            Console.ReadKey();


        }
    }
}
