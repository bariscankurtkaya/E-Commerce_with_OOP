using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductsDal
    {
        Products GetById(int productId);
        List<Products> GetAll();
        void Add(Products product);
        void Update(Products product);
        void Delete(Products product);
        string GetCarBrand(int brandId);
        string GetCarColor(int colorId);
    }
}
