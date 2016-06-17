using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomIteratorExample
{
    class IterableClass : IEnumerable
    {
        List<string> firstNames;
        List<string> lastNames;
       //int iterationCount;
        public IterableClass()
        {
            firstNames = new List<string>() { "Adam", "Mike", "Andrew" };
            lastNames = new List<string>() { "Martell", "Terrill", "Llewellyn" };
            //iterationCount = 0;
        }

        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("Hello");
            for(int i = 0; i < firstNames.Count; i++)
            {
                yield return 5;
                yield return firstNames[i];
                yield return " ";
                yield return lastNames[i];
                yield return "\n";
            }
            yield return "No More Names";
        }
    }
}
