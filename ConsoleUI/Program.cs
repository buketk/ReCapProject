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
            ProductManager product = new ProductManager( new InMemoryProductDal());
            Car car1 = new Car { Id = 1, BrandId=3,ColorId=85, DailyPrice=950, ModelYear=2018, Description="Rang Rover Sport" };
            Car x = new Car();
            Car car2 = new Car();



            foreach (var car in product.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in product.GetById(2))
            {
                Console.WriteLine(car.BrandId+" Numaralı Markaya Ait Tanım:"+car.Description);
            }

         
            
            

        }
    }
}
