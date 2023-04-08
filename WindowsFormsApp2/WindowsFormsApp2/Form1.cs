using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lv_Student.Columns.Add("StudentCode", -2, HorizontalAlignment.Left);
            Lv_Student.Columns.Add("StudentName", -2, HorizontalAlignment.Left);
            Lv_Student.Columns.Add("Birthday", -2, HorizontalAlignment.Left);
            Lv_Student.Columns.Add("Gender", -2, HorizontalAlignment.Left);
            Lv_Student.Columns.Add("MathScore", -2, HorizontalAlignment.Left);
            Lv_Student.ScrollControlIntoView = View.Details;
            List<Student> list = new List<Student>();
            for (int i = 0; i <10; i++)
            {
                Student student = new Student();
                student.Studentcode = (i+1).ToString();
                student.Name = "Nguyen Van A"+i.ToString();
                student.Gender = true;
                student.Mathscore = i + 10;
                var dtStr = "2001-03-21"
                    Datetime myDate
                    

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
