using System;
using System.Collections.Generic;
using System.Text;

namespace Patient
{
    public class PatientsData: PatientsInterface
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public int WardNumber { get; set; }
        public string diseace { get; set; }
        public int BedNumber { get; set; }
        public long MobileNumber { get; set; }

        public void setpatientData()
        {

            Console.WriteLine("Enter Patient Id");
            PatientId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patient Name");
            PatientName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ward Number");
            WardNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter diseace");
            diseace = Console.ReadLine();
            Console.WriteLine("BedNumber");
            BedNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("MobileNumber");
            MobileNumber = long.Parse(Console.ReadLine());
        }

        public void displyPatientdata()
        {
            Console.WriteLine("Patient id {0}", PatientId);
            Console.WriteLine("Patient Name {0}", PatientName);
            Console.WriteLine("Age{0}", Age);
            Console.WriteLine("WardNumber {0}", WardNumber);
            Console.WriteLine("diseace {0}", diseace);
            Console.WriteLine("BedNumber {0}", BedNumber);
            Console.WriteLine("MobileNumber {0}", MobileNumber);
        }
    }
}
