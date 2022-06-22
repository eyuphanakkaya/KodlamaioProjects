using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Id=1,CategoryId=2,ProductName="Masa",UnitInStock=12,UnitPrice=350
            };

            Product product2 = new Product()
            {
                Id=2,CategoryId=2,ProductName="Dolap",UnitInStock=15,UnitPrice=250
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);



            Console.ReadKey();
        }
    }
}
