using System;
using Linq01.Models;
using System.Xml.Linq;
using System.Linq;
using System.Data.Common;

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

        }
    }
}
