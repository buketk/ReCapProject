using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Daily Price 0'dan büyük olmalı.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        //public List<Car> GetById(int Id)
        //{
        //    return _carDal.Get(p => p.Id == Id);
        //}

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(p => p.BrandId == BrandId);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _carDal.GetAll(p=>p.ColorId==ColorId);
        }

        public void Update(Car car) => _carDal.Update(car);

    }
}
