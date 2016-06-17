using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomIteratorExample
{
    class IterableClass02 : IEnumerable
    {
        List<string> firstNames;
        List<string> lastNames;
        public IterableClass02()
        {
            firstNames = new List<string>() { "Adam", "Mike", "Andrew" };
            lastNames = new List<string>() { "Martell", "Terrill", "Llewellyn" };
        }

        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("Hello");
            
            yield return 5 + firstNames[0] + " " + lastNames[0]  +"\n";
            yield return 5 + firstNames[1] + " " + lastNames[1] + "\n";
            yield return 5 + firstNames[2] + " " + lastNames[2] + "\n";
            yield return "No More Names";
        }
    }
}
