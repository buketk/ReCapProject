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
            Car car1 = new Car { Id = 6, BrandId=3,ColorId=85, DailyPrice=950, ModelYear=2018, Description="Rang Rover Sport" };


            foreach (var car in product.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in product.GetById(2))
            {
                Console.WriteLine(car.BrandId+" Numaralı Markaya Ait Tanım:"+car.Description);
            }

            foreach (var car in product.Update(Car { Id = 1, BrandId = 1, ColorId = 55, DailyPrice = 220, ModelYear = 2016, Description = "Wolsvagen Jetta" }))
            {
                Console.WriteLine(car1.Id);
            }
            
            

        }
    }
}
