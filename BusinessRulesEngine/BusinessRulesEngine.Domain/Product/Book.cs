using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.BusinessRulesEngine.Domain.Product
{
   public class Book: Product
    {
        public string  SBIN { get; set; }

        public override void BusinessRuleOperations()
        {
            throw new NotImplementedException();
        }
    }
}
