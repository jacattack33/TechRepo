using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of your rectangle?");
            string length = Console.ReadLine();
            Console.WriteLine("What is the width of your rectangle?");
            string width = Console.ReadLine();
            int area = int.Parse(width) * int.Parse(length);
            Console.WriteLine("The area of the rectangle is: " + area);

        }
    }
}
