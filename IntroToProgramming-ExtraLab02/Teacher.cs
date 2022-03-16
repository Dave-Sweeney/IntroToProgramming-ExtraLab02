using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_ExtraLab02
{
    internal class Teacher : Person
    {
        private string _employeeId;

        public string EmployeeId { get { return _employeeId; } set { _employeeId = value; } }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Enter the teacher's employee number: ");
            EmployeeId = Console.ReadLine();
        }

        public void GetTeacherInformation()
        {
            Console.WriteLine("TEACHER DETAILS");
            GetInfo();
        }

        public void PrintTeacherDetails()
        {
            Console.WriteLine($"{ Name } , { EmployeeId } was born on:  { Birthday }");
        }

        public void FireTeacher()
        {
            // throw new NotImplementedException();
            Console.WriteLine($"{ Name } has been fired.");
        }
    }
}
