using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Weshop.DAL
{
    public class ShoppingInitialiser : DropCreateDatabaseIfModelChanges<ShoppingContext>
    {

        protected override void Seed(ShoppingContext context)
        {

            base.Seed(context);
        }


    }
}