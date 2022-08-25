using System;
using Product;
using Customer;

namespace Main
{
   public  class Program
    {
       static void Main(string[] args)
       {
            

            Console.WriteLine("Choose Option 1 or 2");
            Console.WriteLine("1 For ProductInfo");
            Console.WriteLine("2 CustomerInfo");

            Console.WriteLine("Enter a Option");
            int option = int.Parse(Console.ReadLine()); 
            switch (option)
            {
                case 1:
                    ProductInfo prod = new ProductInfo();
                    Console.WriteLine("Enter ID");
                    prod.ProductId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter ProductName");
                    prod.ProductName = Console.ReadLine();
                    Console.WriteLine("Enter ProductType");
                    prod.ProductType = Console.ReadLine();
                    Console.WriteLine("Enter ProductQuantity");
                    prod.ProductQuantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Price");
                    prod.Price = decimal.Parse(Console.ReadLine());
                    prod.Display();
                    break;
                case 2:

                    CustomerInfo custminfo = new CustomerInfo();
                    Console.WriteLine("Enter CustomerId");
                    custminfo.CustomerId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter CustomerName");
                    custminfo.CustomerName = Console.ReadLine();
                    Console.WriteLine("Enter MobileNumber");
                    custminfo.MobileNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter CustomerAddress");
                    custminfo.CustomerAddress = Console.ReadLine();
                    break;
            }


        }
    }
}

