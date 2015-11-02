using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var distinct = list.Distinct().ToList();

            foreach (var item in distinct)
            {
                Console.WriteLine("{0} -> {1}", item, list.Count(x => x == item));
            }
        }
    }
}
