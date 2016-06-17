using System;
using System.Collections.Generic;

namespace CustomIteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AdamSample();
            Console.WriteLine(" ");
            CarlosSample1();
            Console.WriteLine(" ");
            CarlosSample2();

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

        static public void CarlosSample1()
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

        static public void CarlosSample2()
        {
        
            IterableClass02 test = new IterableClass02();
            foreach (var name in test)
            {
                Console.Write(name);
            }
            Console.ReadLine();
        }
    }
}
