using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveIIntegers
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            CalculateAverage(GenerateListOfPositiveIntegers(input));
        }

        private static List<int> GenerateListOfPositiveIntegers(string numbers)
        {
            var result = new List<int>();

            foreach (var item in numbers)
            {
                result.Add(item-'0');  
            }

            return result;
        }

        private static void CalculateAverage(List<int> numbers)
        {
            var sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }

            Console.WriteLine("Sum: {0}, Avg; {1}",sum,sum/numbers.Count);
        }
    }
}
