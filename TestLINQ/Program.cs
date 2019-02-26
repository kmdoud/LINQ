using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary;

namespace TestLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Linq.About);

            var ProdGt200 = Linq.Products.Where(p => p.Price > 200)
                                         .OrderByDescending(q => q.Price)
                                         .ToArray();

            foreach (var pg in ProdGt200)
            {
                pg.Print();
            }

            //var productsWithVendors = from p in Linq.Products
            //                          join v in Linq.Vendors
            //                          on p.VendorId equals v.Id
            //                          select new
            //                          {
            //                              Vname = v.Name,
            //                              Pname = p.Name,
            //                              Pprice = p.Price

            //                      };
            //foreach(var pv in productsWithVendors)
            //{
            //    Console.WriteLine($"{pv.Vname} {pv.Pname} {pv.Pprice}");
            //}




            //var products = from p in Linq.Products
            //               where p.Price > 200
            //               orderby p.Name 
            //               select p;
            //foreach (var product in products)
            //    Console.WriteLine(product);

            //var vendors = from v in Linq.Vendors
            //              where v.Discount >= .1m
            //              orderby v.Name descending
            //              select v;
            //foreach(var vendor in vendors)
            //{
            //    Console.WriteLine(vendor);
            //}

            //foreach (var vendor in Linq.Vendors)
            //{
            //    if (vendor.Discount >= .1M)
            //    {
            //        Console.WriteLine($"Vendors with discounts >= .1 {vendor}");
            //    }
            //}

            Console.ReadKey();
        }
    }
}
