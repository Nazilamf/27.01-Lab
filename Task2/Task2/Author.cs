using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Author:Human 
    {



        public Author(string name, string surname, byte age, string nationality):base(name,surname,age,nationality)
        {
         
        }


        public string About;
        public Book[] Books;

        public override void ShowFullName()
        {
            Console.WriteLine($"{Name} {Surname}");
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}\nSurname:{Surname}\nAge:{Age}\nNationality:{Nationality}\nAbout{About}");
        }
    }

   
}   

    
