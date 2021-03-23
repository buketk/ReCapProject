using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager car = new CarManager( new EfCarDal());
            BrandManager brand = new BrandManager(new EfBrandDal());
            ColorManager color = new ColorManager(new EfColorDal());

            car.Add(new Car {Id=3,BrandId=4,DailyPrice=150,ModelYear=2014,ColorId=2,Description="Deneme ürünü" });
            


         
            
            

        }
    }
}
