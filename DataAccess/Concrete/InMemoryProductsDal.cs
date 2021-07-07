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
        List<Product> _products;
        List<Brand> _brands;
        List<Color> _colors;
        List<ProductType> _productTypes;
        List<Sex> _sexs;
        public InMemoryProductsDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, BrandId=1, ColorId=1, Price=80, ProductTypeId=2, SexId=1},
                new Product{ProductId=2, BrandId=2, ColorId=2, Price=350, ProductTypeId=3, SexId=2},
                new Product{ProductId=3, BrandId=1, ColorId=1, Price=150, ProductTypeId=1, SexId=3},
                new Product{ProductId=4, BrandId=3, ColorId=3, Price=70, ProductTypeId=3, SexId=1},
                new Product{ProductId=5, BrandId=3, ColorId=2, Price=100, ProductTypeId=2, SexId=3},
                new Product{ProductId=6, BrandId=1, ColorId=4, Price=110, ProductTypeId=1, SexId=2}
            };
            _brands = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Defacto"},
                new Brand{BrandId=2, BrandName="Zara"},
                new Brand{BrandId=3, BrandName="Pull & Bear"}
            };
            _colors = new List<Color>
            {
                new Color{ColorId=1, ColorName="Black"},
                new Color{ColorId=2, ColorName="Red"},
                new Color{ColorId=3, ColorName="White"},
                new Color{ColorId=4, ColorName="Yellow"}
            };
            _productTypes = new List<ProductType>
            {
                new ProductType{ProductTypeId=1, Type="Tshirt"},
                new ProductType{ProductTypeId=2, Type="Trousers"},
                new ProductType{ProductTypeId=3, Type="Sweatshirt"}
            };
            _sexs = new List<Sex>
            {
                new Sex{SexId=1, SexType="Unisex"},
                new Sex{SexId=2, SexType="Woman"},
                new Sex{SexId=3, SexType="Man"}
            };
            
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.Find(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int productId)
        {
            return _products.Find(p => p.ProductId == productId);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.Find(p => p.ProductId == product.ProductId);
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
            return _productTypes.Find(pT => pT.ProductTypeId == productTypeId).Type;
        }

        public string GetProductSex(int sexId)
        {
            return _sexs.Find(s => s.SexId == sexId).SexType;
        }
    }
}
