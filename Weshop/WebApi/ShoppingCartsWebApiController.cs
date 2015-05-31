using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Weshop.DAL;
using Weshop.Models;

namespace Weshop.WebApi
{
    public class ShoppingCartsWebApiController : ApiController
    {
        private ShoppingContext db = new ShoppingContext();

        // GET: api/ShoppingCartsWebApi
        public IQueryable<ShoppingCart> GetShoppingCarts()
        {
            return db.ShoppingCarts;
        }

        // GET: api/ShoppingCartsWebApi/5
        [ResponseType(typeof(ShoppingCart))]
        public IHttpActionResult GetShoppingCart(int id)
        {
            ShoppingCart shoppingCart = db.ShoppingCarts.Find(id);
            if (shoppingCart == null)
            {
                return NotFound();
            }

            return Ok(shoppingCart);
        }

        // PUT: api/ShoppingCartsWebApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutShoppingCart(int productid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shoppingCart.ShoppingCartID)
            {
                return BadRequest();
            }

            db.Entry(shoppingCart).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoppingCartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ShoppingCartsWebApi
        [ResponseType(typeof(ShoppingCart))]
        public IHttpActionResult PostShoppingCart(ShoppingCart shoppingCart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ShoppingCarts.Add(shoppingCart);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = shoppingCart.ShoppingCartID }, shoppingCart);
        }

        // DELETE: api/ShoppingCartsWebApi/5
        [ResponseType(typeof(ShoppingCart))]
        public IHttpActionResult DeleteShoppingCart(int id)
        {
            ShoppingCart shoppingCart = db.ShoppingCarts.Find(id);
            if (shoppingCart == null)
            {
                return NotFound();
            }

            db.ShoppingCarts.Remove(shoppingCart);
            db.SaveChanges();

            return Ok(shoppingCart);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ShoppingCartExists(int id)
        {
            return db.ShoppingCarts.Count(e => e.ShoppingCartID == id) > 0;
        }
    }
}