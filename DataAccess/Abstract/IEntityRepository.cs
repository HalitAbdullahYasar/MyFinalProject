using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //class:referans tip olabilir
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T,bool>>filter);//yazılım geliştirme hayatımızda sadece bir kere yazacağımız şey
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GetAllByCategory(int categoryId); 11.satırda yazdığımız şeyden dolayı bu satırda yazılana ihtiyaç yok 
        
    }
}
