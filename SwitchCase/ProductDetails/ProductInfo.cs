using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDetails
{
    public class ProductInfo

    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int ProductQuantity { get; set; }
        public decimal Price { get; set; }


        public void Display()
        {
            Console.WriteLine("Product Id is : {0} ,  ProductName is : {1}, ProductType is : {2}, ProductQuantity is : {3} , Price as {4}", ProductId, ProductName, ProductType, ProductQuantity, Price);
        }
    }

   
}
