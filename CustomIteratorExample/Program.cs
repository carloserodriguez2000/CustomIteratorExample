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
            IterableClass03 test = new IterableClass03();
            foreach (var name in test)
            {
                Console.Write(name);
            }
            Console.ReadLine();
        }
    }
}
