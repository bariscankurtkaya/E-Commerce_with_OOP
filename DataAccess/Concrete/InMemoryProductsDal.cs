using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryProductsDal : IProductsDal
    {
        List<Products> _products;
        List<Brands> _brands;
        List<Colors> _colors;
        List<ProductTypes> _productTypes;
        List<Sexs> _sexs;
        public InMemoryProductsDal()
        {
            _products = new List<Products>
            {
                new Products{ProductId=1, BrandId=1, ColorId=1, Price=80, ProductTypeId=2, SexId=1},
                new Products{ProductId=2, BrandId=2, ColorId=2, Price=350, ProductTypeId=3, SexId=2},
                new Products{ProductId=3, BrandId=1, ColorId=1, Price=150, ProductTypeId=1, SexId=3},
                new Products{ProductId=4, BrandId=3, ColorId=3, Price=70, ProductTypeId=3, SexId=1},
                new Products{ProductId=5, BrandId=3, ColorId=2, Price=100, ProductTypeId=2, SexId=3},
                new Products{ProductId=6, BrandId=1, ColorId=4, Price=110, ProductTypeId=1, SexId=2}
            };
            _brands = new List<Brands>
            {
                new Brands{BrandId=1,BrandName="Defacto"},
                new Brands{BrandId=2, BrandName="Zara"},
                new Brands{BrandId=3, BrandName="Pull & Bear"}
            };
            _colors = new List<Colors>
            {
                new Colors{ColorId=1, ColorName="Black"},
                new Colors{ColorId=2, ColorName="Red"},
                new Colors{ColorId=3, ColorName="White"},
                new Colors{ColorId=4, ColorName="Yellow"}
            };
            _productTypes = new List<ProductTypes>
            {
                new ProductTypes{ProductTypeId=1, ProductType="Tshirt"},
                new ProductTypes{ProductTypeId=2, ProductType="Trousers"},
                new ProductTypes{ProductTypeId=3, ProductType="Sweatshirt"}
            };
            _sexs = new List<Sexs>
            {
                new Sexs{SexId=1, Sex="Unisex"},
                new Sexs{SexId=2, Sex="Woman"},
                new Sexs{SexId=3, Sex="Man"}
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
            productToUpdate.Price = product.Price;
            productToUpdate.ProductTypeId = product.ProductTypeId;
            productToUpdate.SexId = product.SexId;
        }
        public string GetProductBrand(int brandId)
        {
            //Join ile de yapılabilirdi.
            return _brands.Find(b => b.BrandId == brandId).BrandName;
        }

        public string GetProductColor(int colorId)
        {
            return _colors.Find(c => c.ColorId == colorId).ColorName;
        }

        public string GetProductType(int productTypeId)
        {
            return _productTypes.Find(pT => pT.ProductTypeId == productTypeId).ProductType;
        }

        public string GetProductSex(int sexId)
        {
            return _sexs.Find(s => s.SexId == sexId).Sex;
        }
    }
}
