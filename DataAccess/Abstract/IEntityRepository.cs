using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic constraint : Sadece Entites>Concrete'teki nesnelerin erişebilmesi için sınırlama
    //class: Referans Tipler
    //IEntity: IEntity ve IEntity implemente eden nesneler
    //new()= New'lenebilir olan nesneler
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
