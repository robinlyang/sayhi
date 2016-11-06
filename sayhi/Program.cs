using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayhi
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, number1, number2;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hi there " + name);
            Console.Write("Enter hours worked: ");
            number1 = Console.ReadLine();
            Console.Write("Enter rate per hour: ");
            number2 = Console.ReadLine();
            double total, x, y;
            x = Convert.ToDouble(number1);
            y = Convert.ToDouble(number2);
            if(x <= 40)
            {
                total = x * y;
            }
            else
            {
                total = x * y * 1.5;
            }
            
            Console.WriteLine("Total pay is " + total.ToString("c"));
            Console.ReadLine();
        }
    }
}
