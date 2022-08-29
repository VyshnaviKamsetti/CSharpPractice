using System;
using System.Collections.Generic;
using System.Text;

namespace overridingPractice
{
   public  partial class Partialemployee
    {
        public void displayFullname()
        {
            Console.WriteLine("Full name is :{0} {1}",FirstName , LastName);
        }

        public void displayDetails()
        {
            Console.WriteLine("Employee Details :");
            Console.WriteLine("First Name :{0}",FirstName);
            Console.WriteLine("Last Name :{0}", LastName);
            Console.WriteLine("Salary :{0}", Salary);
            Console.WriteLine("Age :{0}", age);
            Console.WriteLine("MobileNumber :{0}", MobileNumber);
            Console.WriteLine("Address :{0}", Address);
            Console.WriteLine("Gender :{0}", Gender);

        }
       
    }
}
