using System.Data.Entity;
using Weshop.Models;

namespace Weshop.DAL
{
    public class ShoppingContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        public System.Data.Entity.DbSet<Weshop.Models.ShoppingCart> ShoppingCarts { get; set; }
    }
}