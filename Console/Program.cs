using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsManager productsManager = new ProductsManager(new InMemoryProductsDal());

            Console.WriteLine(productsManager.GetById(2).DailyPrice); 

            foreach (var product in productsManager.GetAll())
            {
                string brandName = productsManager.GetCarBrand(product.BrandId);
                Console.WriteLine("Marka: " + brandName + " Günlük Ücretler:" + product.DailyPrice);
            }
        }
    }
}
