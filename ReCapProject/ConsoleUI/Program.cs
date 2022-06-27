using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
            }
        }
    }
}
