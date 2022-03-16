using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_ExtraLab02
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthday;
        private int _age;

        
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime Birthday 
        { 
            get 
            { 
                return _birthday; 
            } 
            set 
            {
                _birthday = value;
                CalculateAge(value);
            } 
        }

        public int Age { get { return _age; }  }

        private void CalculateAge(DateTime birthday)
        {
            _age = 0;

            _age = DateTime.Now.Year - birthday.Year;

            if (DateTime.Now.Month < birthday.Month || (DateTime.Now.Month == birthday.Month && DateTime.Now.Day < birthday.Day))
            {
                _age--;
            }            
        }
        public string Name { get { return $"{ FirstName } { LastName }"; } }

        public virtual void GetInfo()
        {
            bool invalidBirthday = true;

            Console.WriteLine("Enter the person's first name");
            this.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the person's last name");
            this.LastName = Console.ReadLine();

            do
            {
                try
                {
                    Console.WriteLine("Enter the person's birthday");
                    this.Birthday = DateTime.Parse(Console.ReadLine());
                    invalidBirthday = false;
                } catch(Exception)
                {
                    Console.WriteLine("Please enter a valid date");
                }
                
            } while (invalidBirthday);
            
        }
    }
}
