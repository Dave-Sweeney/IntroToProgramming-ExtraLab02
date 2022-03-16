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
       
            ConsoleProcessor.DisplayMainPortal();
            ConsoleProcessor.ProcessMainPortalInput();

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

    }

}
