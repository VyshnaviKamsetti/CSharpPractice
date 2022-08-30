using System;

namespace ExceptionProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Option As Insert for Insert the Records....");
            Console.WriteLine("Choose Option As Update for Update the Records....");
            Console.WriteLine("Choose Option As Delete for Delete the Records....");
            Console.WriteLine("Choose Option As Search for Search the Record with ID....");

            Console.WriteLine("Choose Option");
            string option = Console.ReadLine();

            DBConnection obj = new DBConnection();
            DBConnectionInterface dbinter = obj;

            if(option == "Insert"|| option =="Update" || option =="Delete" || option == "Search")
            {
                
                switch (option)
                {
                    case "Insert":
                        dbinter.insertData();
                        dbinter.DisplayData();
                        break;

                    case "Update":
                        dbinter.updateData();
                        dbinter.DisplayData();
                        break;
                    case "Delete":
                        dbinter.DeleteData();
                        break;
                    case "Search":
                        dbinter.SearchData();
                        break;

                }
            }
            else
            {

                Console.WriteLine("Please choose Appropriate option");
            }
            

        }
    }
}
