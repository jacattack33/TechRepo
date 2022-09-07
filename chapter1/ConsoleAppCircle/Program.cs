using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius:");
            string userInput = Console.ReadLine();
            double radius = Double.Parse(userInput);
            double area = (double)(Math.PI * radius * radius);
            Console.WriteLine("The area of the circle of radius " + radius + " is: " + area);
            double circumference = (double)(2 * Math.PI * radius);
            Console.WriteLine("The circumference is " + circumference);
            double diameter = (double)(2 * radius);
            Console.WriteLine("The diameter is " + diameter);
            Console.WriteLine("What is the mpg for your car?");
            //string userInput2 = Console.ReadLine();
            
        }
    }
}
