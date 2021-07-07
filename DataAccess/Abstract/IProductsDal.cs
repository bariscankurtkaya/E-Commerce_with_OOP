using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductsDal
    {
        Product GetById(int productId);
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        string GetProductBrand(int brandId);
        string GetProductColor(int colorId);
        string GetProductType(int productTypeId);
        string GetProductSex(int sexId);
    }
}
