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
                    "{0}: Marka: {1}  --- Renk: {2} --- Yıl:{3}  --- Günlük Ücretler:{4} --- Özellikleri: {5}"
                    , product.ProductId, brandName, colorName, product.ModelYear, product.DailyPrice, product.Description
                    );
            }

            Console.WriteLine("3.Arabanın rengi: " +productsManager.GetCarColor(3));
            Products product1 = productsManager.GetById(5);
            Console.WriteLine("5.Arabanın markası: " +product1.BrandId);
        }
    }
}
