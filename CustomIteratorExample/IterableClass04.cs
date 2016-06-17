using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomIteratorExample
{
    class IterableClass04
    {
        List<string> firstNames;
        List<string> lastNames;
        public IterableClass04(List<string> firstNames, List<string> lastNames)
        {
            this.firstNames = firstNames;
            this.lastNames = lastNames;
        }

        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("Hello");
            for (int i = 0; i < firstNames.Count; i++)
            {
                yield return 5 + firstNames[i] + " " + lastNames[i] + "\n";
            }
            yield return "No More Names";
        }

    }
}
