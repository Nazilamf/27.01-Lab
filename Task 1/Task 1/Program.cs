using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Product pr1 = new Product("Iphone 14", 2000, 3);


            pr1.Sell(2000);
            pr1.Sell(2000);

            pr1.ShowInfo();

        }
    }
}
