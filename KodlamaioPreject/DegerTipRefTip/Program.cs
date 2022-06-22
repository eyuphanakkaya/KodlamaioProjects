using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerTipRefTip
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Sahra";
            Person person2 = new Person();
            person2.FirstName = "Selin";
            person1 = person2;
            Console.WriteLine(person1.FirstName);
            

            Customer customer = new Customer();
            customer.FirstName="Burak";
            Console.WriteLine(customer.FirstName);
            Person person3 = customer;
            person3.FirstName = "Alii";
            Console.WriteLine(customer.FirstName);

            CustomerManager customerManager = new CustomerManager();

            Employee employee = new Employee();
            employee.FirstName = "Arda";


            customerManager.Add(employee);


            Console.ReadKey();

        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public int CrediCardNumber { get; set; }

    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class CustomerManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
