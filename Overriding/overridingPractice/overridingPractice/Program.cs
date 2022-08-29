using System;

namespace overridingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Partialemployee emp = new Partialemployee();
            emp.getId = 1;
            emp.getFirstName = "Kamsetti";
            emp.getLastName = "Vyshnavi";
            emp.getSalary = 35000;
            emp.getage = 22;
            emp.getMobileNumber = 911000000;
            emp.getAddress = "HYD,YallareddyGuda";
            emp.getGender = "Female";
            emp.displayFullname();
            emp.displayDetails();
        }
    }
}
