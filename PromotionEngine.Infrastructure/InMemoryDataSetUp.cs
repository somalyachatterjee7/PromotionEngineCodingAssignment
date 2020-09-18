using PromotionEngine.Domain.Cart.Promotion;
using PromotionEngine.Domain.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Infrastructure
{
    public class InMemoryDataSetUp
    {
        private readonly IProduct product;

        private readonly IPromotionConfig promotionConfig;
        public InMemoryDataSetUp(IProduct product, IPromotionConfig promotionConfig)
        {
            this.product = product;
            this.promotionConfig = promotionConfig;
        }

        public void SetUpProductData()
        {
            this.product.Add(new Product {
                Id = 1,
                IsPromotionApplicable = true,
                Name = "A",
                Price = 50.00m,
                PromotionType = Domain.Cart.Promotion.PromotionType.ProductSetBased
            });
            this.product.Add(new Product
            {
                Id = 1,
                IsPromotionApplicable = true,
                Name = "B",
                Price = 30.00m,
                PromotionType = Domain.Cart.Promotion.PromotionType.ProductSetBased
            });
            this.product.Add(new Product
            {
                Id = 1,
                IsPromotionApplicable = true,
                Name = "C",
                Price = 20.00m,
                PromotionType = Domain.Cart.Promotion.PromotionType.ProductSetBased
            });
            this.product.Add(new Product
            {
                Id = 1,
                IsPromotionApplicable = true,
                Name = "D",
                Price = 15.00m,
                PromotionType = Domain.Cart.Promotion.PromotionType.ProductSetBased
            });
        }

        public void SetUpPromotionConfig()
        {
            this.promotionConfig.Add(new PromotionConfig {Id=1,ProductId=1,PromotionItemSetCount=3,PromotionItemSetValue=130,PromotionType= PromotionType.ProductSetBased });
            this.promotionConfig.Add(new PromotionConfig { Id = 1, ProductId = 2, PromotionItemSetCount = 2, PromotionItemSetValue = 45, PromotionType = PromotionType.ProductSetBased });
            this.promotionConfig.Add(new PromotionConfig { Id = 1, ProductId = 3, PromotionItemSetCount = 0, PromotionItemSetValue = 30,AssociatedProductID=4, PromotionType = PromotionType.BuyOneGetAnother });
        }


    }
}
