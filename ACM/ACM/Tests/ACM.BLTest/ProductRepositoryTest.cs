namespace ACM.BLTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ACM.BL;

    [TestClass]
   public class ProductRepositoryTest
    {
        [TestMethod ]
        public void RetrieveTest()
        {
            //Arrange
            var productrepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Scoth Finger",
                Description = " Assort of 14 oven baked fresh biscuits",
                CurrentPrice = 1.1f
            };
            //Act

            var actual = productrepository.Retrieve(2);
            //Assert
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ProductName , actual.ProductName);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

    }
}
