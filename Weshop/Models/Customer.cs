using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weshop.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}