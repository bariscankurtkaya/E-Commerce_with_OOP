using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    //We can use ADO.NET, Dapper or NHibernate but I used Entity Framework --ORM-- Object Relational Mapping
    public class SqlProductsDal : DbContext, IProductsDal
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Sex> Sexs { get; set; }
        public SqlProductsDal()
        {
            foreach (var product in Products)
            {
                var brandName = Brands.Find(product.BrandId).BrandName;
                Console.WriteLine(brandName);
                /*Console.WriteLine(
                    "{0}: Brand: {1}  --- Color: {2} --- Sex:{3}  --- Price:{4} --- Type: {5}"
                    , product.ProductId, product.BrandId, product.ColorId, product.SexId, product.Price, product.ProductTypeId
                    );*/
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ECommerce;Trusted_Connection=true");
        }
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductId);
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public string GetProductBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public string GetProductColor(int colorId)
        {
            throw new NotImplementedException();
        }

        public string GetProductSex(int sexId)
        {
            throw new NotImplementedException();
        }

        public string GetProductType(int productTypeId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
