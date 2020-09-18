using BusinessRulesEngine.BusinessRulesEngine.Application;
using System;

namespace BusinessRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessRulesFactory businessRulesFactory = new BusinessRulesFactory();
            int randomProductType = new Random().Next();
            businessRulesFactory.GetProductInstance(randomProductType).BusinessRuleOperations();
        }
    }
}
