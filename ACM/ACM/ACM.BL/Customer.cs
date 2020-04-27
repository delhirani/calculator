using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public string  EmailAddress { get; set; }
        public  int CustomerId { get; private set; }
        private string _lastName;
        private string firstName;

        public string   FullName
        {
            get
            {
              return LastName + " , " + FirstName;
            }
        } 
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

        public string FirstName { get => firstName; set => firstName = value; }

    }
}
