using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace ExceptionProject
{
    public class DBConnection: DBConnectionInterface
    {
        public int Doctorid { get; set; }
        public string Doctorname { get; set; }
       
        public string DoctorName { get; set; }
        public string experience { get; set; }
        public string specialization { get; set; }
        public string Course { get; set; }
        SqlConnection con = new SqlConnection("server=localhost;database=HospitalManagement;integrated security=true;");

        public void insertData()
        {

            Console.WriteLine("Enter DoctorName");
            DoctorName = Console.ReadLine();
            Console.WriteLine("Enter experience");
            experience = Console.ReadLine();
            Console.WriteLine("Enter specialization");
            specialization = Console.ReadLine();
            Console.WriteLine("Enter Course");
            Course = Console.ReadLine();

            con.Open();
            string query = "insert into DoctorInfo values('" + DoctorName + "','" + experience + "','" + specialization + "','" + Course + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Inserted successfully");

        }
        public void updateData()

        {
            try
            {
                Console.WriteLine("Enter DoctorID");
                Doctorid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter DoctorName");
                DoctorName = Console.ReadLine();
                Console.WriteLine("Enter experience");
                experience = Console.ReadLine();
                Console.WriteLine("Enter specialization");
                specialization = Console.ReadLine();
                Console.WriteLine("Enter Course");
                Course = Console.ReadLine();

                con.Open();
                string query = "update   DoctorInfo set DoctorName='" + DoctorName + "',experience='" + experience + "',specialization='" + specialization + "',Course='" + Course + "' where Doctorid='" + Doctorid + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Updated successfully");
            }
            catch (Exception)
            {
                Console.WriteLine("plese enter Id and try again.");

            }

        }
        public void DeleteData()
        {
            try
            {
                Console.WriteLine("Enter DoctorID");
                Doctorid = int.Parse(Console.ReadLine());


                con.Open();
                string query = "delete  from DoctorInfo  where Doctorid='" + Doctorid + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Deleted successfully");
            }
            catch (Exception)
            {

                Console.WriteLine("plese enter Id and try again.");
            }

        }
        public void SearchData()
        {
            
            Console.WriteLine("Enter DoctorID");
            Doctorid = int.Parse(Console.ReadLine());

            SqlDataAdapter da = new SqlDataAdapter("select * from DoctorInfo  where Doctorid='" + Doctorid + "'",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "DoctorInfo");
            int x = ds.Tables[0].Rows.Count;
            for (int i= 0; i <= 0;i++)
            {
                if (Doctorid.ToString() == ds.Tables[0].Rows[i][0].ToString())
                {
                    Console.Write("Doctorid : " + ds.Tables[0].Rows[i][0].ToString());
                    Console.Write(" , DoctorName : " + ds.Tables[0].Rows[i][1].ToString());
                    Console.Write(" , Experience : " + ds.Tables[0].Rows[i][2].ToString());
                    Console.Write(" , Specialization : " + ds.Tables[0].Rows[i][3].ToString());
                    Console.Write(" , Course :" + ds.Tables[0].Rows[i][4].ToString());
                    Console.WriteLine();
                    Console.ReadKey();
                }

            }

        }
        public void DisplayData()
        {
            Console.WriteLine(" Doctor Name : {0}  , experience :  {1} ,Cource : {2} , Specailization :{3} ",DoctorName,experience,Course, specialization);
        }

    }
}
