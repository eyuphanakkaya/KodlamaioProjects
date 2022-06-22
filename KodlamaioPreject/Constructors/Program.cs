using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=2,FirstName="Irmak",LastName="Pınar",City="İst" };

            Console.WriteLine(customer1.FirstName);

            Customer customer = new Customer(2,"Ali","Şaşkın","Ankara");


            Console.WriteLine(customer.FirstName);

            Console.ReadKey();

        }
       
    }



    class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int id,string firstName,string lastName,string city )
        {
            Id = id;
            FirstName = firstName;
            lastName = LastName;
            City = city;

        }

        public int Id  { get; set; }
        public string   FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }




    }
}
