using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Domain.Cart.Promotion
{
    public interface IPromotionConfig
    {
        PromotionConfig Add(PromotionConfig promotionConfig);

        PromotionConfig Update(PromotionConfig promotionConfig);

        bool Delete(int Id);

        List<PromotionConfig> Get();

        PromotionConfig GetbyId(int Id);

        List<PromotionConfig> PromotionConfigs { get; set; }
    }
}
