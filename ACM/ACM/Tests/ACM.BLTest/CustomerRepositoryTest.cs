using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void Retrievevalid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1);
            

        }
            // Act
            //Assert

        
    }
}
