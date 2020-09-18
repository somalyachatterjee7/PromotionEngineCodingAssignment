using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Domain.Product
{
    public interface IProduct
    {
        Product Add(Product product);

        Product Update(Product product);

        bool Delete(int Id);

        List<Product> Get();

        Product GetbyId(int Id);

        List<Product> Products { get; set; }

    }
}
