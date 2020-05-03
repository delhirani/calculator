using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    //public delegate int test(int x, int y);
     public class Product
    {
        public Product()
        {

        }
        public Product(int productid)
        {
            ProductId = null;
        }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float? CurrentPrice { get; set; }
        public int? ProductId { get;  set; }

        
        public Product Retrieve(int productId)
        {
            return new Product();
        }
        public void Save()
        {

        }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice ==null) isValid = false;
            return isValid;
        }


    }

      
}
