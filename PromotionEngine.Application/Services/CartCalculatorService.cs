using PromotionEngine.Application.Contracts;
using PromotionEngine.Domain.Cart;
using PromotionEngine.Domain.Cart.Promotion;
using PromotionEngine.Domain.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Application.Services
{
   public class CartCalculatorService : ICartCaluclatorService
    {
        private IPromotionConfig PromotionConfig;
        private IProduct Product;
        public CartCalculatorService(IPromotionConfig PromotionConfig, IProduct Product)
        {
            this.PromotionConfig = PromotionConfig;
            this.Product = Product;
        }

        public decimal GetProductSetBasedPromotionValue(CartItem cartItem)
        {
            var promotionConfig = this.PromotionConfig.Get().FirstOrDefault(x=>x.ProductId == cartItem.productId);
            var PromotionSet = GetPromotionItemSets(cartItem.count, promotionConfig.PromotionItemSetCount);
            var offerSetItemsPrice = PromotionSet.Item1 * promotionConfig.PromotionItemSetValue;
            var nonsetItemsPrice = PromotionSet.Item2 * this.Product.GetbyId(cartItem.productId).Price;
            return offerSetItemsPrice + nonsetItemsPrice;
        }

        public double GetProductvalueIncart(CartItem cartItem)
        {
            throw new NotImplementedException();
        }

        private Tuple<decimal, decimal> GetPromotionItemSets(int nuberofProducts, int offerSetValue)
        {
            var mean = nuberofProducts + offerSetValue / 2;
            var nonPromotionItemCount = nuberofProducts - (mean - (mean % offerSetValue));
            var offerSet = (mean % offerSetValue);
            return new Tuple<decimal, decimal>(offerSet, nonPromotionItemCount);
        }

    }
}
