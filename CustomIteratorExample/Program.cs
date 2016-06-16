using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>() { "Adam", "Mike", "Andrew" };
            List<string> lastNames = new List<string>() { "Martell", "Terrill", "Llewellyn" };

            IterableClass04 test = new IterableClass04(firstNames, lastNames);
            foreach (var name in test)
            {
                Console.Write(name);
            }
            Console.ReadLine();
        }

        static public void AdamSample()
        {
            IterableClass test = new IterableClass();
            foreach (var name in test)
            {
                Console.Write(name);
            }
            Console.ReadLine();
        }

        static public void CarlosSample()
        {
            List<string> firstNames = new List<string>() { "Adam", "Mike", "Andrew" };
            List<string> lastNames = new List<string>() { "Martell", "Terrill", "Llewellyn" };

            IterableClass04 test = new IterableClass04(firstNames, lastNames);
            foreach (var name in test)
            {
                Console.Write(name);
            }
            Console.ReadLine();
        }
    }
}
