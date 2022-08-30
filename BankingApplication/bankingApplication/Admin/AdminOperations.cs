using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Admin
{
    public class AdminOperations: AdminOperationsInterface
    {
        public string UserId { get; set; }
        public string Password { get; set; }

        public long AccountId { get; set; }
        public string BankName { get; set; }

        public string AccountHolderName { get; set; }

        public string Branch { get; set; }

        public string IFSC { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }


        SqlConnection con = new SqlConnection("server=localhost;database=HospitalManagement;integrated security=true;");

        public void insertData()
        {

            Console.WriteLine("Enter BankName");
            BankName = Console.ReadLine();
            Console.WriteLine("Enter AccountHolderName");
                AccountHolderName = Console.ReadLine();
                Console.WriteLine("Enter Branch");
                Branch = Console.ReadLine();
                Console.WriteLine("Enter IFSC");
                IFSC = Console.ReadLine();
                Console.WriteLine("Enter DateOfBirth");
                DateOfBirth = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Address");
                Address = Console.ReadLine();

                con.Open();
                string query = "insert into BankingDetails values('" + BankName + "','" + AccountHolderName + "','" + Branch + "','" + IFSC + "','" + DateOfBirth + "','" + Address + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Inserted successfully");
            
            
        }

        public void DeleteData()
        {
            try
            {
                Console.WriteLine("Enter AccountId");
                AccountId = int.Parse(Console.ReadLine());


                con.Open();
                string query = "delete  from BankingDetails  where AccountId='" + AccountId + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Deleted successfully");
            }
            catch (Exception)
            {

                Console.WriteLine("plese enter Id and try again....");
            }

        }
    }
}
