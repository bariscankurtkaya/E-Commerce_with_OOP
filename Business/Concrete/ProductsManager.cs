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
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int productId)
        {
            return _productDal.GetById(productId);
        }
        public string GetProductBrand(int brandId)
        {
            return _productDal.GetProductBrand(brandId);
        }

        public string GetProductColor(int colorId)
        {
            return _productDal.GetProductColor(colorId);
        }

        public string GetProductSex(int sexId)
        {
            return _productDal.GetProductSex(sexId);
        }

        public string GetProductType(int productTypeId)
        {
            return _productDal.GetProductType(productTypeId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
