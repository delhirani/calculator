namespace ACM.BLTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ACM.BL;
    [TestClass ]
    public class OrderRepositoryTest
     {
        [TestMethod]
        public void RetrieveValid()
        {
            var orderrepository = new OrderRepository();
            int orderId = 10;
            var expected = new Order(10);

            var actual = orderrepository.Retrieve(10);

        }

    }
}
