using PromotionEngine.Domain.Cart;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Application.Contracts
{
   public interface ICartService
    {
        bool AdditemToCart(CartItem cartItem);

        int DeleteItemFromCart(CartItem cartItem);

        decimal CalculateCartValue(List<CartItem> cartItems); 
    }
}
