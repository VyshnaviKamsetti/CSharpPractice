using System;
using System.Collections.Generic;
using System.Text;

namespace Admin
{
    public class AdminData:AdminInterface
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }

        public void AdminDetails()
        {
            Console.WriteLine("Admin Id :{0} /n Name :{1} /n Password{2}", AdminId, AdminName, Password);
        }

        public void setAdminList()
        {
            Console.WriteLine("Enter Admin Id");
            AdminId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Admin Name");
            AdminName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            Password = Console.ReadLine();

        }
    }
}
