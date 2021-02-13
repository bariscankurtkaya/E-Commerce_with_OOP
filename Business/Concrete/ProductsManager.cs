using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductsManager : IProductsService
    {
        IProductsDal _productDal;
        public ProductsManager(IProductsDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Products product)
        {
            _productDal.Add(product);
        }

        public void Delete(Products product)
        {
            _productDal.Delete(product);
        }

        public List<Products> GetAll()
        {
            return _productDal.GetAll();
        }

        public Products GetById(int productId)
        {
            return _productDal.GetById(productId);
        }

        public string GetCarBrand(int brandId)
        {
            return _productDal.GetCarBrand(brandId);
        }

        public string GetCarColor(int colorId)
        {
            return _productDal.GetCarColor(colorId);
        }

        public void Update(Products product)
        {
            _productDal.Update(product);
        }
    }
}
