using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Nationality;


        public Human(string name,string surname,byte age,string nationality)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Nationality = nationality;

        }

        public virtual void ShowFullName()
        {
            Console.WriteLine($"{Name} {Surname}");
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}\nSurname:{Surname}\nAge:{Age}\nNationality:{Nationality}");
        }
    }
}
