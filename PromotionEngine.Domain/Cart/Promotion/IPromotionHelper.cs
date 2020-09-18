using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Domain.Cart.Promotion
{
   public interface IPromotionHelper
    {
        Tuple<int, int> GetPromotionItemSets(int nuberofProducts, int offerSetValue);
        
    }
}
