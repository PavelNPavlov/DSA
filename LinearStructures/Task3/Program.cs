using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            var integers = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == string.Empty)
                {
                    break;
                }

                integers.Add(int.Parse(input));
            }

            integers.Sort();

            foreach (var item in integers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
