using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_ExtraLab02
{
    internal class Student : Person
    {
        private string _studentId;

        public string StudentId
        { 
            get 
            { 
                return _studentId; 
            } 
            set 
            {
                _studentId = value;
            } 
        }
            
        public void GetStudentInformation()
        {
            Console.WriteLine();
            Console.WriteLine("STUDENT DETAILS:");
            Console.WriteLine("Enter the Student Id");
            _studentId = Console.ReadLine();
            base.GetInfo();
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine($"Student ID: { StudentId }\n{ Name } is { Age } years old.");
            if (Age < 18)
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine("THIS STUDENT IS NOT OLD ENOUGH TO BE ENROLLED!");
                Console.WriteLine("**********************************************");
                Console.WriteLine();
                
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadKey();
        }

    }


}
