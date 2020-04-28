using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // - Arrange 

            Customer customer = new Customer
            {
                FirstName = "Varunavi",
                LastName = "Mahaveer"
            };
            string expected = "Mahaveer, Varunavi";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // - Arrange 

            Customer customer = new Customer
            {
                LastName = "Mahaveer"
            };
            string expected = "Mahaveer";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // - Arrange 

            Customer customer = new Customer
            {
                FirstName = "Varunavi"

            };
            string expected = "Varunavi";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
    }
}