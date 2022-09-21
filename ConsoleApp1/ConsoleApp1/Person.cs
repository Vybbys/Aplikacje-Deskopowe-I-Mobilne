using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {

        private string name, surname;
        private int age;


        public Person()
        {
            name = "Adam";
            surname = "Kowalski";
            age = 79;
        }

        public Person(string n, string s, int a)
        {
            name = n;
            surname = s;
            age = a;
        }

        public void showInfo()
        {
            Console.WriteLine("***************************");
            Console.WriteLine($"Imie:  {name}");
            Console.WriteLine($"Nazwisko: {surname}");
            Console.WriteLine($"Wiek: {age}");
            Console.WriteLine("****************************");

        }

        public void SetSurname(string new_surname)
        {
            if(new_surname != "")
            {
                surname = new_surname;
            }
            
        }

        public string GetSurname()
        {
            return surname;
        }

    };
}
