using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        Customer customer = new Customer();

        [TestInitialize]
        public void testInit()
        {
            customer.FirstName = "Varunavi";
            customer.LastName = "Mahaveer";
        }
         
       
        [TestMethod]
        public void FullNameTestValid()
        {
            // - Arrange 
            string expected = "Mahaveer, Varunavi";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // - Arrange 
            customer.FirstName = null;
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

        [TestMethod]
        public void StaticTest()
        {
            // - Arrange 
            var c1 = new Customer();
            c1.FirstName = "Varunavi";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Vedhika";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Mahaveer";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]

        public void WithEmailEmptyValidate()
        {
            customer.EmailAddress = "mahaveed@gmail.com"; 
            string expected = "mahaveed@gmail.com";
            bool actual = customer.Validate();

            Assert.AreEqual(true , actual);
        }
        public void WithEmailValidate()
        {
            customer.EmailAddress = "mahaveed@gmail.com";
            string expected = "mahaveed@gmail.com";
            bool actual = customer.Validate();

            Assert.AreEqual(true, actual);
        }
    }
}