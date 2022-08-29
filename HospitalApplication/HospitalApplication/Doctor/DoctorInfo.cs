using System;
using System.Collections.Generic;
using System.Text;

namespace Doctor
{
    public class DoctorInfo:DoctorInterface

    {
        public int DoctorId { get; set; }
        public string  DoctorName { get; set; }
        public string Course { get; set; }
        public string Specialization { get; set; }
        public DateTime AppointmentTimings { get; set; }
        public int Experience { get; set; }
        public int BedNumber { get; set; }


        public void setDoctor()
        {
            Console.WriteLine("Enter Doctor Id");
            DoctorId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Doctor Name");
            DoctorName = Console.ReadLine();
            Console.WriteLine("Enter Course");
            Course = Console.ReadLine();
            Console.WriteLine("Specialization");
            Specialization = Console.ReadLine();
            Console.WriteLine("Enter Appointment timings");
            AppointmentTimings = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Experience");
            Experience = int.Parse(Console.ReadLine());
        }

        public void getDoctorData()
        {
            Console.WriteLine("Doctor Id :{0} , Doctor Name is {1} , Course{2} , Specialization{3} , Appointment Timings {4} , Experience{5}",DoctorId,DoctorName,Course,Specialization,AppointmentTimings,Experience);
        }

       

    }
}
