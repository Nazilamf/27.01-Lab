using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Human hm1 = new Human("Leyla", "Quliyeva", 25, "Turkish");

            //hm1.ShowFullName();
            //hm1.ShowInfo();



            //Book bk1 = new Book("Code DaVinchi", "Dan Brown", "Novel", 30);
            //bk1.ShowInfo();



            Author aut1 = new Author("Dan", "Brown", 45, "English") { About = ":adbgsh" };

            //aut1.ShowFullName();
            //aut1.ShowInfo();

            Book[] books = new Book[2];
            Book newbk1 = new Book("Angels and Demon", "Novel", 45);
            Book newbk2 =new Book("Code Da Vinchi","Novel",35);

            books[0] = newbk1;
            books[1] = newbk2;

            Author aut1 = new Author("Dan", "Brown", 45, "English") { About = ":adbgsh" };

            for (int i = 0; i < books.Length; i++)
            {
                

            }

            

        }
    }
}
