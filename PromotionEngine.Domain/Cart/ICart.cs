using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Domain.Cart
{
   public interface ICart
    {
        CartItem Add(CartItem cartItem);

        CartItem Update(CartItem cartItem);

        bool Delete(int Id);

        List<CartItem> Get();

        CartItem GetbyId(int Id);

        List<CartItem> CartItems { get; set; }

        List<Cart> Carts { get; set; }
    }
}
