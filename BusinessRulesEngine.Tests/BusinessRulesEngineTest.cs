using BusinessRulesEngine.BusinessRulesEngine.Application;
using BusinessRulesEngine.BusinessRulesEngine.Domain.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessRulesEngine.Tests
{
    [TestClass]
    public class BusinessRulesEngineTest
    {
      
        [TestMethod]
        public bool GetProductInstanceTest()
        {
            //arrange
            var mockVideoObject = new Video { IsAddOnRequired = true, AttachedVideoId = 1 }; 
            //act
            BusinessRulesFactory businessRulesFactory = new BusinessRulesFactory();
            var result = businessRulesFactory.GetProductInstance(1);
            //assert
            return Assert.Equals(result.GetType(), mockVideoObject.GetType());
          
        }
    }
}
