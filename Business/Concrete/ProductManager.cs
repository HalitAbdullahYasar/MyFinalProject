using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    
    public class ProductManager : IProductService
    {

        EfProductDal _efProductDal;

        public ProductManager(EfProductDal efProductDal)
        {
            _efProductDal = efProductDal;
        }

        //private IProductDal _productDal1;

        //private List<Product> _productDal;



        public List<Product> GetAll()
        {

            //iş kodları
            //yetkisi var mı?
            // _productDal.GetAll();
            return _efProductDal.GetAll();
        }
        public List<Product> GetAllByCategoryId(int id)
        {
            return _efProductDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _efProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
