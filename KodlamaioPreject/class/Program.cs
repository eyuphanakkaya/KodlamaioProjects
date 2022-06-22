using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            { 
            Id=1,Urunmarka="Monster",UrunKategoriad="Laptop"
            };
            Product product2 = new Product()
            {
                Id = 2,
                Urunmarka = "Apple",
                UrunKategoriad = "Televizyon"
            };
            Product product3 = new Product()
            {
                Id = 3,
                Urunmarka = "Lenovo",
                UrunKategoriad = "Tablet"
            };


            Product[] products = new Product[] 
            {
                product1,product2,product3
            };

            foreach (var productt in products)
            {
                Console.WriteLine(productt.Id + ":" + productt.Urunmarka);
            }
            Console.WriteLine();
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id + ":" + products[i].Urunmarka);
            }
            Console.WriteLine();
            int x = 0;
            while (x<products.Length)//koşul 0 dan büyükse koşulun içine gir
                
            {
                Console.WriteLine(products[x].Id + ":" + products[x].Urunmarka);//productsın içindeki id
                x++;
            }


            Console.ReadKey();
            
        }
    }


    class Product
    {
        public int Id { get; set; }
        public string Urunmarka { get; set; }
        public string UrunKategoriad { get; set; }
    }
}
