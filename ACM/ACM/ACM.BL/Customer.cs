using ICustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : IEquatable<Customer>,IValidate
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        private string _lastName;


        public string LastName
        {

            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

        public bool Equals(Customer other)
        {
            if (other == null) return false;
            return (CustomerId.Equals(other.CustomerId) && FullName.Equals(other.FullName)
                && EmailAddress.Equals(other.EmailAddress) && FirstName.Equals(other.FirstName)
                && LastName.Equals(other.LastName)
                );
        }
    }
}
