using System;
using Product;
using Customer;

namespace Ecommerce
{
    public class Program
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
                    Productlist prod = new Productlist();
                    ProductInterface pinter = prod;
                    pinter.Display();
                    break;
                case 2:
                    Customerlist clist = new Customerlist();
                    CustomerInterface cinter = clist;
                    cinter.Display();
                    break;
            }
        }
    }
}
