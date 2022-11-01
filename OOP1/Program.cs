using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;  //CategoryId=2 Mobilya Kategorisidir.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product() { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 5 };

            //case sensitive
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager(); //101
            productManager.Add(product1);

            Console.WriteLine(product1.ProductName); 



            // int,double,bool... değer tip
            // diziler,class,abstract class, interface ... referans tip
            // ref-out
        }
    }
}
