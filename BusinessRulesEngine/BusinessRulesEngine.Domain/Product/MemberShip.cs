using System;

namespace BusinessRulesEngine.BusinessRulesEngine.Domain.Product
{
    public class MemberShip: Product
    {
        public DateTime  ExpiryDate { get; set; }

        public override void BusinessRuleOperations()
        {
            throw new NotImplementedException();
        }
    }
}
