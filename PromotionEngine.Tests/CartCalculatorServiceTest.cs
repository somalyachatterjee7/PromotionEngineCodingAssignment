using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PromotionEngine.Application.Contracts;
using PromotionEngine.Application.Services;
using PromotionEngine.Domain.Cart;
using PromotionEngine.Domain.Cart.Promotion;
using PromotionEngine.Domain.Product;
using System.Collections.Generic;

namespace PromotionEngine.Tests
{
    [TestClass]
    public class CartCalculatorServiceTest
    {
        private ICartCaluclatorService cartCaluclatorService;
        private ICart cart;
        private Mock<IPromotionConfig> promotionConfig;
        private Mock<IProduct> product;
        public CartCalculatorServiceTest()
        {
            this.promotionConfig = new Mock<IPromotionConfig>();
            this.product = new Mock<IProduct>();
            cartCaluclatorService = new CartCalculatorService(promotionConfig.Object, product.Object);
            cart = new Cart();
        }

        [TestMethod]
        public bool GetProductSetBasedPromotionValueTestMethod1()
        {
            //arrange
            List<PromotionConfig> promotionConfigs = new List<PromotionConfig>();
            promotionConfigs.Add(new PromotionConfig { Id = 1, ProductId = 1, PromotionItemSetCount = 3, PromotionItemSetValue = 130, PromotionType = PromotionType.ProductSetBased });
            promotionConfig.Setup(p => p.Get()).Returns(promotionConfigs);
            product.Setup(p => p.GetbyId(1)).Returns(new Product {Id=1,Name="A",Price=130,PromotionType=PromotionType.ProductSetBased });
            var cartItem = this.cart.Add(new CartItem { productId = 1, count = 5, PromotionType = Domain.Cart.Promotion.PromotionType.ProductSetBased });
           //act
            var value = cartCaluclatorService.GetProductSetBasedPromotionValue(cartItem);

            //assert
            return Assert.Equals(value, 230);
        }
    }
}
