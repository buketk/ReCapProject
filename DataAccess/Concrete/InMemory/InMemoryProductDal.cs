using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=55,DailyPrice=220,ModelYear=2016,Description="Wolsvagen Jetta"},

                new Car{Id=2,BrandId=2,ColorId=65,DailyPrice=450,ModelYear=2017,Description="BMW i8"},

                new Car{Id=3,BrandId=3,ColorId=75,DailyPrice=300,ModelYear=2019,Description="Skoda Octavia"},

                new Car{Id=4,BrandId=2,ColorId=55,DailyPrice=500,ModelYear=2016,Description="BMW 320"},

                new Car{Id=5,BrandId=1,ColorId=55,DailyPrice=215,ModelYear=2014,Description="Wolsvagen Golf"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c=>c.BrandId==BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
