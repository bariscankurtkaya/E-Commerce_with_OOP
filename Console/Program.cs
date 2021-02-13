//Written by : Barışcan KURTKAYA
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsManager productsManager = new ProductsManager(new InMemoryProductsDal());

            foreach (var product in productsManager.GetAll())
            {
                string brandName = productsManager.GetCarBrand(product.BrandId);
                string colorName = productsManager.GetCarColor(product.ColorId);
                Console.WriteLine(
                    product.ProductId + ": " + 
                    "Marka: " + brandName +
                    " |Renk: " + colorName +
                    " |Yıl: " + product.ModelYear +
                    " |Günlük Ücretler:" + product.DailyPrice +
                    " |Özellikleri: " + product.Description
                    );
            }

            Console.WriteLine(productsManager.GetCarColor(3));
            Products product1 = productsManager.GetById(5);
            Console.WriteLine(product1.BrandId);
        }
    }
}
