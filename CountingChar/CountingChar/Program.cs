using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Console.WriteLine("String: " + example);
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in example)
            {
                if (!counts.ContainsKey(c))
                {
                    counts.Add(c, 1);                  
                }
                else
                {
                    counts[c]++;
                }                              
            }
            foreach (KeyValuePair<char, int> pair in counts)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }
            Console.ReadLine();
        }
    }
}
