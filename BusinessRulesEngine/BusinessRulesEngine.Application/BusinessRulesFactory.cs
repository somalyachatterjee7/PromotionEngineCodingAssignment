using BusinessRulesEngine.BusinessRulesEngine.Domain.Product;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BusinessRulesEngine.BusinessRulesEngine.Application
{
    public class BusinessRulesFactory 
    {
        public Product GetProductInstance(int x)
        {
            switch (x)
            {
                case 1:
                    return new Video();
                case 2:
                    return new Book();
                case 3:
                    return new MemberShip();
                default:
                    throw new NotImplementedException();

            }

        }

    }
}
