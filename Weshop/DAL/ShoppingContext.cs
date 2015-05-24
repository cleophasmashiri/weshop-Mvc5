using System.Data.Entity;
using Weshop.Models;

namespace Weshop.DAL
{
    public class ShoppingContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}