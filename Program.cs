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
           
            var seafood = from p in ProductList
                          .Where(p => p.Category == "Seafood")
                          select new { p.ProductName, p.UnitPrice };

            foreach (var item in seafood)
                Console.WriteLine($"{item.ProductName}: {item.UnitPrice:C}");
            #endregion

            #region 2. Get a list of only the product names from ProductList. Print each name.
            
            var productNames = from p in ProductList
                               select p.ProductName;

            foreach (var name in productNames)
                Console.WriteLine(name);
            #endregion

        }
    }
}
