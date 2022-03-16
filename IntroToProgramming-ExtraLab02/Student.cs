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
    
        public override void GetInfo()
        {
            base.GetInfo();

            
        }

        public void GetStudentInformation()
        {
            Console.WriteLine("STUDENT DETAILS:");
            Console.WriteLine("Enter the Student Id");
            _studentId = Console.ReadLine();
            base.GetInfo();
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine($"{ Name } , { StudentId } was born on:  { Birthday }");
        }

    }


}
