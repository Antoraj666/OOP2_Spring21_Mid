using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask03
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();
            tri.X = 5;
            tri.Y = 6;
            tri.Z = 5;
            tri.ShowInfo();
            tri.TestTriangle();

            Student st = new Student();
            st.Name = "Antoraj";
            st.Id = "18-38901-3";
            st.Cgpa = 3.50f;
            st.Department = "BSc CSSE";
            st.ShowInfo();

            Account ac = new Account();
            ac.AccName = "Antoraj";
            ac.AcId = "55894AAC";
            ac.Balance = 50000;
            ac.Deposit(12000);
            ac.Withdraw(6000);

            Course co = new Course();
            co.CourseName = "OOP2";
            co.CourseCredit = 3;
            co.CourseCode = "CS12201";
            co.ShowCourseInfo();

        }
    }
}
