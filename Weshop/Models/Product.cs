using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weshop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}