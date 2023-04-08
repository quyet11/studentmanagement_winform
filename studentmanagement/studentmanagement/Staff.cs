using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentmanagement
{
    internal class Staff
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string PersonalID { get; set; }



        
        public double Salary { get; set; }

        public Staff() { }
        public Staff(string name, string address, string phone, int age, string personalID, double salary)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Age = age;
            PersonalID = personalID;
            Salary = salary;
        }
    }
}
