namespace ACM.BLTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ACM.BL;

    [TestClass]
     public class ProductTest
    {

        Product product = new Product();

        [TestInitialize]
        public void testInit()
        {
            product.ProductId = 5;
            
        }

        [TestMethod]
        public void ProductIdNotNuLL()
        {
            bool expected = true;
            bool Actual = product.ProductId.HasValue;
            Assert.AreEqual(expected, Actual);
        }

        [TestMethod]
        public void ProductIdNuLL()
        {
            product.ProductId = null;
            bool Actual = product.ProductId.HasValue; ;
            bool expected = true;
            Assert.AreNotEqual(expected, Actual);
        }

    }
}
