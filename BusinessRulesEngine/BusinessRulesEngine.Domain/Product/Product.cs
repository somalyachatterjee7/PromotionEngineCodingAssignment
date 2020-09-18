namespace BusinessRulesEngine.BusinessRulesEngine.Domain.Product
{
    public abstract class Product
    {
        public Product()
        {
        }
        public int Id { get; set; }
        public bool IsPhysicalProduct { get; set; }

        public abstract void BusinessRuleOperations();
    }
}
