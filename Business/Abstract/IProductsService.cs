using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductsService
    {
        Products GetById(int productId);
        List<Products> GetAll();
        void Add(Products product);
        void Update(Products product);
        void Delete(Products product);
        string GetProductBrand(int brandId);
        string GetProductColor(int colorId);
        string GetProductType(int productTypeId);
        string GetProductSex(int sexId);
    }
}
