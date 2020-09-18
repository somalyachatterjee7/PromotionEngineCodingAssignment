using PromotionEngine.Domain.SeedWork;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace PromotionEngine.Domain.Cart.Promotion
{
   public class PromotionConfig:Entity, IPromotionConfig
    {
        public PromotionConfig()
        {
            PromotionConfigs = new List<PromotionConfig>();
        }

        public int ProductId { set; get; }

        public Product.Product Product { set; get; }

        public int PromotionItemSetCount { set; get; }

        public decimal PromotionItemSetValue { set; get; }

        public PromotionType PromotionType { set; get; }

        public int AssociatedProductID { set; get; }

        public List<PromotionConfig> PromotionConfigs { set; get; }

        public PromotionConfig Add(PromotionConfig promotionConfig)
        {
            PromotionConfigs.Add(promotionConfig);
            return promotionConfig;
        }

        public bool Delete(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<PromotionConfig> Get()
        {
            return PromotionConfigs;
        }

        public PromotionConfig GetbyId(int Id)
        {
            throw new System.NotImplementedException();
        }

        public PromotionConfig Update(PromotionConfig promotionConfig)
        {
            throw new System.NotImplementedException();
        }
    }
}
