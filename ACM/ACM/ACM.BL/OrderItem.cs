﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {

        public OrderItem()
        {
                
        }

        public OrderItem( int OrderId)
        {

        }

        
        public int  OrderItemId  { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }


        public void Retrieve()
        {

        }
        public void Save()
        {

        }
        public bool Validate()
        {
            var isValid = true;
            if (Quantity == null) isValid = false;
            if (ProductId == null) isValid = false;
            if (PurchasePrice  == null) isValid = false;
            return isValid;
        }


    }
}