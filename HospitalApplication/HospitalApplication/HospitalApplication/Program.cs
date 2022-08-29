using System;
using Doctor;
using Admin;
using Patient;
namespace HospitalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Option 1 or 2 or 3");
            Console.WriteLine("1 For Admin Details ");
            Console.WriteLine("2 For Doctor Details");
            Console.WriteLine("3 For Patient Details");

            Console.WriteLine("Enter a Option");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AdminData admin = new AdminData();
                    AdminInterface admin1 = admin;
                    Console.WriteLine("Welcome to the Hospital Management System. Please Enter and Verify the Admin Details Here... Enter any key to Continue the Process");
                    Console.ReadKey();
                    admin1.setAdminList();
                    admin1.AdminDetails();
                    break;

                case 2:
                    DoctorInfo doc = new DoctorInfo();
                    DoctorInterface docint = doc;
                    Console.ReadKey();
                    Console.WriteLine("Enter any key to Process the Doctor Info....");
                    Console.WriteLine("Welcome to the Hospital Management System .Please Enter and verify the Doctor Details Here...");
                    Console.ReadKey();
                    docint.setDoctor();
                    docint.getDoctorData();
                    Console.ReadKey();
                    break;

                case 3:
                    PatientsData patdata = new PatientsData();
                    PatientsInterface patientsInterface = patdata;
                    Console.ReadKey();
                    Console.WriteLine("Enter any key to Process the Doctor Info....");
                    Console.WriteLine("Welcome to the Hospital Management System .Please Enter and verify the Doctor Details Here...");
                    Console.ReadKey();
                    patientsInterface.setpatientData();
                    patientsInterface.displyPatientdata();
                    break;

                    Console.WriteLine("Welcome to the Hospital Management System");

            }

        }
    }
}
