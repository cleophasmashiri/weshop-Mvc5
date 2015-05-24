using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weshop.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }

        public int CustomerID { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }

        public DateTime DatePurchased { get; set; }
    }
}