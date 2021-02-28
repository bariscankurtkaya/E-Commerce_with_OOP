using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryProductsDal : IProductsDal
    {
        List<Products> _products;
        List<Brands> _brands;
        List<Colors> _colors;
        public InMemoryProductsDal()
        {
            _products = new List<Products>
            {
                new Products{ProductId=1, BrandId=1, ColorId=1, DailyPrice=350, ModelYear=2016, Description="Hasarsız"},
                new Products{ProductId=2, BrandId=2, ColorId=2, DailyPrice=550, ModelYear=2020, Description="Hasarsız"},
                new Products{ProductId=3, BrandId=1, ColorId=1, DailyPrice=250, ModelYear=2005, Description="Hasarlı"},
                new Products{ProductId=4, BrandId=3, ColorId=3, DailyPrice=320, ModelYear=2013, Description="Hasarsız"},
                new Products{ProductId=5, BrandId=3, ColorId=2, DailyPrice=300, ModelYear=2011, Description="Hasarlı"},
                new Products{ProductId=6, BrandId=1, ColorId=4, DailyPrice=350, ModelYear=2016, Description="Hasarsız"}
            };
            _brands = new List<Brands>
            {
                new Brands{BrandId=1,BrandName="Ferrari"},
                new Brands{BrandId=2, BrandName="Mercedes"},
                new Brands{BrandId=3, BrandName="Porsche"}
            };
            _colors = new List<Colors>
            {
                new Colors{ColorId=1, ColorName="Siyah"},
                new Colors{ColorId=2, ColorName="Kırmızı"},
                new Colors{ColorId=3, ColorName="Beyaz"},
                new Colors{ColorId=4, ColorName="Sarı"},
            };
            
        }
        public void Add(Products product)
        {
            _products.Add(product);
        }

        public void Delete(Products product)
        {
            Products productToDelete = _products.Find(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Products> GetAll()
        {
            return _products;
        }

        public Products GetById(int productId)
        {
            return _products.Find(p => p.ProductId == productId);
        }

        public void Update(Products product)
        {
            Products productToUpdate = _products.Find(p => p.ProductId == product.ProductId);
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.Description = product.Description;
        }
        public string GetCarBrand(int brandId)
        {
            //Join ile de yapılabilirdi.
            return _brands.Find(b => b.BrandId == brandId).BrandName;
        }
        public string GetCarColor(int colorId)
        {
            return _colors.Find(c=> c.ColorId==colorId).ColorName;
        }

        public List<Products> GetAll(Expression<Func<Products, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Products Get(Expression<Func<Products, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
