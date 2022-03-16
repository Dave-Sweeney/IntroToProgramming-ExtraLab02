using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_ExtraLab02
{
    internal class ConsoleProcessor
    {

        public static void DisplayMainPortal()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Univeristy of College!");
            Console.WriteLine("1. Student Portal");
            Console.WriteLine("2. Instructor Portal");
            Console.WriteLine("3. Course Portal");
            Console.WriteLine("4. Program Portal");
            Console.WriteLine("5. Exit");
            Console.WriteLine();

        }

        

        public static void ProcessMainPortalInput()
        {
            
            string input = "";
            
            int inputToNumber = 0;
            bool invalidInput = true;

            while (invalidInput)
            {
                try
                {
                    Console.Write("Please select an option: ");
                    input = Console.ReadLine();
                    inputToNumber = int.Parse(input);
                    invalidInput = false;
                }
                catch (Exception ex) { Console.WriteLine("Invalid Input.  Please select from the menu."); }
            }

            invalidInput = true;

            while (invalidInput)
            {
                switch (inputToNumber)
                {
                    case 1:
                        DisplayStudentPortal();
                        ProcessStudentPortalInput();
                        break;
                    case 2:
                        DisplayTeacherPortal();
                        ProcessTeacherPortalInput();
                        break;
                    case 3:
                        DisplayCoursePortal();
                        ProcessCoursePortalInput();
                        break;
                    case 4:
                        DisplayProgramPortal();
                        ProcessProgramPortalInput();
                        break;
                    case 5:
                        Console.WriteLine("See you next time!");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;
                    default:
                        invalidInput = true;
                        break;
                }
            }
            
            
        }

        public static void DisplayStudentPortal()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Student Portal!");
            Console.WriteLine("1. Enter new Student");
            Console.WriteLine("2. Display students");
            Console.WriteLine("3. Go to main menu");
            Console.WriteLine();
        }

        public static void ProcessStudentPortalInput()
        {
            string input = "";
            int inputToNumber = 0;
            bool invalidInput = true;

            while (invalidInput)
            {
                try
                {
                    Console.Write("Please select an option: ");
                    input = Console.ReadLine();
                    inputToNumber = int.Parse(input);
                    invalidInput = false;
                }
                catch (Exception ex) { Console.WriteLine("Invalid Input.  Please select from the menu."); }
            }

            switch (inputToNumber)
            {
                case 1:
                    Student student = new Student();
                    student.GetStudentInformation();
                    Console.WriteLine();
                    student.PrintStudentDetails();
                    break;
                case 2:
                    break;
                case 3:
                    DisplayMainPortal();
                    ProcessMainPortalInput();
                    break;
                default:
                    break;
            }
        }
        private static void DisplayTeacherPortal()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Instructor Portal!");
            Console.WriteLine("1. Enter new instructor");
            Console.WriteLine("2. Display instructors");
            Console.WriteLine("3. Go to main menu");
            Console.WriteLine();
        }
        private static void ProcessTeacherPortalInput()
        {
            string input = "";
            int inputToNumber = 0;
            bool invalidInput = true;

            while (invalidInput)
            {
                try
                {
                    Console.Write("Please select an option: ");
                    input = Console.ReadLine();
                    inputToNumber = int.Parse(input);
                    invalidInput = false;
                }
                catch (Exception ex) { Console.WriteLine("Invalid Input.  Please select from the menu."); }
            }

            switch (inputToNumber)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    DisplayMainPortal();
                    ProcessMainPortalInput();
                    break;
                default:
                    break;
            }
        }
        private static void DisplayCoursePortal()
        {
            PortalNotImplemented();
        }
        private static void ProcessCoursePortalInput()
                {
                    // throw new NotImplementedException();
                }
        private static void DisplayProgramPortal()
        {
            PortalNotImplemented();
        }
        private static void ProcessProgramPortalInput()
                {
                    // throw new NotImplementedException();
                }

        private static void PortalNotImplemented()
        {
            Console.Clear();
            Console.WriteLine("This portal has not been implemented yet.  Try again later");
            Console.ReadKey();
            DisplayMainPortal();
        }
    }
}
