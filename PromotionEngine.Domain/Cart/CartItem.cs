using PromotionEngine.Domain.Cart.Promotion;
using PromotionEngine.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Domain.Cart
{
   public class CartItem:Entity
    {
        public int productId { get; set; }
        public int count { get; set; }
        public Product.Product Product { get; set; }
        public PromotionType PromotionType { get; set; }
    }
}
