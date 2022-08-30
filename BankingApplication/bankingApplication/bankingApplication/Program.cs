using System;
using Admin;

namespace bankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Option As Insert for Insert the Records....");
            Console.WriteLine("Choose Option As Delete for Delete the Records....");
            Console.WriteLine("Choose Option");
            string option = Console.ReadLine();

            AdminOperations obj = new AdminOperations();
            AdminOperationsInterface admini = obj;
            if(option == "Insert" || option == "Delete")
            {
                switch (option)
                {
                    case "Insert":
                        admini.insertData();
                        break;
                    case "Delete":
                        admini.DeleteData();
                        break;
                }
            }
        }
    }
}
