using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            var list = new List<int> { 1, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 68, 6, 1, 1, 1, 1, 1 };

            var expectedResult = new List<int> { 1, 1, 1, 1, 1 };

            var longestSequence = LongestSequence(list);

            if(expectedResult.Count != longestSequence.Count && expectedResult[0]!=longestSequence[0])
            {
                Console.WriteLine("Fail");
                return;
            }

            Console.WriteLine("Success");
            foreach (var item in longestSequence)
            {
                Console.WriteLine(item);
            }

        }

        private static List<T> LongestSequence<T>(List<T> list)
            where T : IComparable
        {
            var sequenceMemember = new List<T>();
            var sequenceCount = new List<int>();

            sequenceMemember.Add(list[0]);
            sequenceCount.Add(1);

            for (int i = 1; i < list.Count; i++)
            {
                if (!list[i].Equals(sequenceMemember[sequenceMemember.Count-1]))
                {
                    sequenceMemember.Add(list[i]);
                    sequenceCount.Add(1);
                    continue;
                }

                sequenceCount[sequenceCount.Count - 1]++;
            }

            var result = new List<T>();

            for (int i = 0; i < sequenceCount.Max(); i++)
            {
                result.Add(sequenceMemember[sequenceCount.IndexOf(sequenceCount.Max())]);
            }

            return result;
        }
    }
}
