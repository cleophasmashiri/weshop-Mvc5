using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Weshop.Models;

namespace Weshop.DAL
{
    public class ShoppingInitialiser : DropCreateDatabaseIfModelChanges<ShoppingContext>
    {

        protected override void Seed(ShoppingContext context)
        {

            var products = new List<Product>
            {
                new Product { Title = "BMW 420i", Description = "BMW 420i", Image = "bmw420i.jpg"},
                new Product { Title = "BMW 420D", Description = "BMW 420D", Image = "bmw420D.jpg"},
                new Product { Title = "BMW 430i", Description = "BMW 430i", Image = "bmw430i.jpg"},
                new Product { Title = "BMW 430D", Description = "BMW 430D", Image = "bmw430D.jpg"}

            };

            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();

            var customers = new List<Customer>
            {
                new Customer { FirstName = "Francis", LastName = "Mashiri", Email = "francismashiri@gmail.com", Address = "46 Countesses Ave" },
                new Customer { FirstName = "Kimberly", LastName = "Mashiri", Email = "kimmashiri@gmail.com", Address = "46 Countesses Ave" },
                new Customer { FirstName = "Cleophas", LastName = "Mashiri", Email = "cleophasmashiri@gmail.com", Address = "46 Countesses Ave" },
                new Customer { FirstName = "Rosa", LastName = "Mashiri", Email = "rosamashiri@gmail.com", Address = "46 Countesses Ave" },
                new Customer { FirstName = "Sandra", LastName = "Mashiri", Email = "sandramashiri@gmail.com", Address = "46 Countesses Ave" }
            };
            
            customers.ForEach(c => context.Customers.Add(c));

            var purchases = new List<Purchase>
            {
                new Purchase
                {
                    CustomerID = 1,
                    DatePurchased = DateTime.Now,
                    Products = products.Where(p => p.ProductID < 3).ToList()
                }
            };

            purchases.ForEach(p => context.Purchases.Add(p));
            context.SaveChanges();

        }


    }
}