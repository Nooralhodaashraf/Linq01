using Linq01.Models;
using System;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;

namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ProductList = DataSources.Source.ProductList;

            #region 1. Get all products from the "Seafood" category. Print each  product's name and price.

            //var seafood = from p in ProductList
            //              .Where(p => p.Category == "Seafood")
            //              select new { p.ProductName, p.UnitPrice };

            //foreach (var item in seafood)
            //    Console.WriteLine($"{item.ProductName}: {item.UnitPrice:C}");
            #endregion

            #region 2. Get a list of only the product names from ProductList. Print each name.

            //var productNames = from p in ProductList
            //                   select p.ProductName;

            //foreach (var name in productNames)
            //    Console.WriteLine(name);
            #endregion

            #region 3. Sort all products by UnitPrice (ascending). Print each  product's name and price. 

            //var sortedProducts = from p in ProductList
            //                     orderby p.UnitPrice
            //                     select new { p.ProductName, p.UnitPrice };


            //foreach (var item in sortedProducts)
            //    Console.WriteLine($"{item.ProductName}: {item.UnitPrice:C}");

            #endregion

            #region 4. Get all products where UnitPrice is between 10 and 30 
            //var productsInRange = from p in ProductList
            //                      where p.UnitPrice >= 10 && p.UnitPrice <= 30
            //                      select new { p.ProductName, p.UnitPrice };

            //foreach (var item in productsInRange)
            //    Console.WriteLine($"{item.ProductName}: {item.UnitPrice:C}");

            #endregion

            #region 5. Get all products that are in stock (UnitsInStock > 0) and   belong to the "Condiments" category.

            //var inStockCondiments = from p in ProductList
            //                        where p.UnitsInStock > 0 && p.Category == "Condiments" // الcategory دي مش موجودة لوحدها اسمها دايما Spices & Condiments ف يا اما نسيبها كدا يا اما نكتبها ع بعض يا اما نحقق الكود الجاي اللي معمول كومنت 
            //                        where p.UnitsInStock > 0 && p.Category.Contains("Condiments")
            //                        select new { p.ProductName, p.UnitPrice };

            //foreach (var item in inStockCondiments)
            //    Console.WriteLine($"{item.ProductName}: {item.UnitPrice:C}");

            #endregion


            #region 6. Create a new anonymous type with three properties: ● Name → the product name● Price → the unit price● StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"● Print the result.
            //var product1 =  new  { Name = "product1",Price = 1000,StockStatus = 2 };

            //Console.WriteLine($"Name: {product1.Name}, Price: {product1.Price}, StockStatus: {(product1.StockStatus > 0 ? "Available" : "Out of Stock")}");

            #endregion

            #region 7. Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.
           //var productsWithPosition = ProductList.Select((p, index) => new { Position = index + 1, p.ProductName });



           // foreach (var item in productsWithPosition)
           //    Console.WriteLine($"{item.Position}. {item.ProductName}");

            #endregion
        }
    }
}
