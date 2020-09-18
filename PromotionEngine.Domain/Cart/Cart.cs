using PromotionEngine.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Domain.Cart
{
   public class Cart:Entity,ICart
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
            Carts = new List<Cart>();
        }
        public bool IsPromotionApplied { get; set; }
        public int CartItemId{ get; set; }
        public double CartValue { get; set; }
        public List<Cart> Carts { get; set; }

        public List<CartItem> CartItems { get; set; }

        public Product.Product Product { get; set; }

        public CartItem CartItem { get; set; }

        public CartItem Add(CartItem cartItem)
        {
            this.CartItems.Add(cartItem);
            return cartItem;
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> Get()
        {
            throw new NotImplementedException();
        }

        public CartItem GetbyId(int Id)
        {
            throw new NotImplementedException();
        }

        public CartItem Update(CartItem cartItem)
        {
            throw new NotImplementedException();
        }
    }
}
