namespace ACM.BLTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ACM.BL;

    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void Retrievevalid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            int customerId = 1;
            var expected = new Customer(customerId)
            {
                EmailAddress = "mahaveerd@gmail.com",
                FirstName = "Varunavi",
                LastName = "Mahaveer"
            };
            // Act
            var actual = customerRepository.Retrieve(1);
            //actual = expected;
            //Assert 
            Assert.AreEqual(true, actual.Equals(expected));
        }



    }
}
