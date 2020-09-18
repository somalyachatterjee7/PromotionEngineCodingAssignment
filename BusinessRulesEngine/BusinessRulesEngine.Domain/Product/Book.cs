using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.BusinessRulesEngine.Domain.Product
{
   public class Book: Product
    {
        public string  Name { get; set; }
        public string Author { get; set; }
        public override void BusinessRuleOperations()
        {
            throw new NotImplementedException();
        }
    }
}
