using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Student
    {
        public Student() { }
        public string Name { get; set; }
        public string Studentcode { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public double Mathscore { get; set; }
        public bool Gender { get; set; }

        public Student(string name, string studentcode, string address, DateTime birthday, double mathscore, bool gender)
        {
            Name = name;
            Studentcode = studentcode;
            Address = address;
            Birthday = birthday;
            Mathscore = mathscore;
            Gender = gender;
        }   
    }
}
