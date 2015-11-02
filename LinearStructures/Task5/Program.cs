using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { -5, 1, -2, 10, -100, -2, 1, 2, 3, 4 };

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            list.RemoveAll(x => x < 0);

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
