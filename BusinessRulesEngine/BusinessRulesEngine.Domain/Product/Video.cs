using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.BusinessRulesEngine.Domain.Product
{
   public class Video:Product
    {
        public bool IsAddOnRequired { get; set; }
        public int AttachedVideoId { get; set; }
        public Uri VideoUri { get; set; }

        public override void BusinessRuleOperations()
        {
            throw new NotImplementedException();
        }
    }
}
