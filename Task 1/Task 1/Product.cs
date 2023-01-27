using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    internal class Product
    {

        public Product(string name,double price,int count)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }
        
        
        
        public string Name;
        public double Price;
        public int Count;
        public double Income;


        public void Sell(double income)
        {
            
              Income += Price;
              Count--;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}\nPrice:{Price}\nCount:{Count}\nPIncome:{Income}");
             
        }


    }
}
