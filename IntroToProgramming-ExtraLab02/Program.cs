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
            //GetStudentInformation();

            //PrintStudentDetails("David", "Sweeney", "1/1/2000");

            Student student = new Student();
            student.GetStudentInformation();
            Console.WriteLine();
            student.PrintStudentDetails();
            Console.WriteLine($"{ student.Name } is { student.Age }");

            Teacher teacher = new Teacher();
            teacher.GetTeacherInformation();
            Console.WriteLine();
            teacher.PrintTeacherDetails();

            teacher.FireTeacher();


            Console.ReadKey();
        }

    }

}
