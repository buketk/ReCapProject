using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Car> GetAll();
        List<Car> GetById(int BrandId);
        void Update(Car car);
    }
}
