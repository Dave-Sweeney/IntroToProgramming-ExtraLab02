using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_ExtraLab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DisplayMainPortal();

            Student student = new Student();
            student.GetStudentInformation();
            Console.WriteLine();
            student.PrintStudentDetails();           

            Teacher teacher = new Teacher();
            teacher.GetTeacherInformation();
            Console.WriteLine();
            teacher.PrintTeacherDetails();

            teacher.FireTeacher();


            Console.ReadKey();
        }

        public static void DisplayMainPortal()
        {
            Console.WriteLine("1. Student Portal");
            Console.WriteLine("2. Instructor Portal");
            Console.WriteLine("3. Course Portal");
            Console.WriteLine("4. Program Portal");
            Console.WriteLine();

        }

    }

}
