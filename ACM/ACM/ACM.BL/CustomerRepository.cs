﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class CustomerRepository
    {
        public Customer Retrieve(int customerId)

        {
            Customer customer = new Customer(customerId);

            if (customerId ==1 )
            {
                customer.EmailAddress = "mahaveerd@gmail.com";
                customer.FirstName = "Varunvi";
                customer.LastName = "Mahaveer";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;    
        }

    }
}
