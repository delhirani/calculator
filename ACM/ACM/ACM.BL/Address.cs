using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Address
    {

        public Address()
        {

        }

        public Address( int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public int AdderssType { get;  set; }
        public String City { get; set; }
        public String Country  { get; set; }
        public String PostalCode { get; set; }
        public String State { get; set; }
        public String StreetLine1 { get; set; }
        public String StreetLine2 { get; set; }

        public bool Validate ()
        {
            var isValid = true;
            if (PostalCode == null) isValid = false;
            return isValid;   

        }


    }
}
