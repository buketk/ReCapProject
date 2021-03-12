using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        //GetById, GetAll, Add, Update, Delete 
        List<Car> GetAll();
        List<Car> GetById(int BrandId);
        //Ürünleri Marka id'sine göre listele
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        
    }
}
