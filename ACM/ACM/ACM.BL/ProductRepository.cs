using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if (productId==2)

            {
                product.ProductName = "Scoth Finger";
                product.Description = " Assort of 14 oven baked fresh biscuits";
                product.CurrentPrice = 1.1f;
            }
            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }

    }
}
