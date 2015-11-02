using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            var distinct = list.Distinct().ToList();

            var repetitions = new List<int>();

            distinct.ForEach(x => repetitions.Add(list.Count(z => z == x)));

            var max = repetitions.Max();

            if(max >= list.Count/2+1)
            {
                Console.WriteLine("Majorent -> " + distinct[repetitions.IndexOf(max)]);
                return;
            }

            Console.WriteLine("No majorent");

        }


    }
}
