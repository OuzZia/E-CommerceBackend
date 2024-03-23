using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            //var result = productManager.GetProductDetails();
            //if (result.Success)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName + " " + product.CategoryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            var result = productManager.GetByUnitPrice(5, 20);
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " " + item.UnitPrice);
                }
            }
            //Console.WriteLine("-----------------");

            //foreach (var p1 in productManager.GetAllByCategoryId(5))
            //{
            //    Console.WriteLine(p1.ProductName);
            //}
            //Console.WriteLine("-----------");

            //foreach (var p2 in productManager.GetByUnitPrice(10,12))
            //{
            //    Console.WriteLine(p2.ProductName + " "+ p2.UnitPrice );
            //}

            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}
        }
    }
}
