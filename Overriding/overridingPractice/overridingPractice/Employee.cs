using System;
using System.Collections.Generic;
using System.Text;

namespace overridingPractice
{
    public partial class Partialemployee
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private double Salary;
        private int age;
        private long MobileNumber;
        protected string Address;
        protected string Gender;
        

        public int getId
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string getFirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public string getLastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public double getSalary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
        public int getage
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public long getMobileNumber
        {
            get
            {
                return MobileNumber;
            }
            set
            {
                MobileNumber = value;
            }
        }

        public string getAddress
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string getGender
        {
            get
            {
                return Gender;
            }
            set
            {
                Gender = value;
            }
        }

    }
}
