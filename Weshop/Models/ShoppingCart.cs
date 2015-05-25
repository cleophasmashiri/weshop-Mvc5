using System.Collections;
using System.Collections.Generic;

namespace Weshop.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartID { get; set; }
        public int CustomerID { get; set; }
        public virtual  ICollection<Product> Products { get; set; }
        
    }
}