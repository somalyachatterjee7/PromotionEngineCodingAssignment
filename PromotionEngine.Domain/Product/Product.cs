using PromotionEngine.Domain.Cart.Promotion;
using PromotionEngine.Domain.SeedWork;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Domain.Product
{
   public class Product: Entity, IProduct, IAggregateRoot
    {
        public Product()
        {
            Products = new List<Product>();
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal? OldPrice { get; set; }
        public decimal? SpecialPrice { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public bool IsPromotionApplicable { get; set; }

        public PromotionType PromotionType { get; set; }
        public List<Product> Products { get; set; }

        public Product Add(Product product)
        {
            Products.Add(product);
            return product;
        }

        public bool Delete(int Id)
        {
           return Products.Remove(Products.FirstOrDefault(x => x.Id == Id));
        }

        public Product GetbyId(int Id)
        {
            return Products.FirstOrDefault(x => x.Id == Id);
        }

        public List<Product> Get()
        {
            return Products;
        }

        public Product Update(Product product)
        {
            throw new System.NotImplementedException();
        }
        //we can add many more attributes based in requirements 
        //we can enable user based Product store
    }
}
