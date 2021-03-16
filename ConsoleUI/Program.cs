using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager product = new CarManager( new InMemoryProductDal());
            Car car1 = new Car { Id = 1, BrandId=3,ColorId=85, DailyPrice=950, ModelYear=2018, Description="Rang Rover Sport" };
            Car x = new Car();
            Car car2 = new Car();



            foreach (var car in product.GetAll())
            {
                Console.WriteLine(car.Description);
            }



         
            
            

        }
    }
}
