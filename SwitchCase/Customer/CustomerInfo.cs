using System;
using System.Collections.Generic;
using System.Text;

namespace Customer

{
    public class CustomerInfo


    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }
        public long MobileNumber { get; set; }
        public string CustomerAddress { get; set; }
     


        public void Display()
        {
            Console.WriteLine("CustomerId is : {0} ,  CustomerName is : {1}, MobileNumber is : {2}, CustomerAddress is : {3} ", CustomerId, CustomerName, MobileNumber, CustomerAddress);
        }
    }


}