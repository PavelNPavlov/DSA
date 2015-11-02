using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main()
        {
            var list = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var distinct = list.Distinct().ToList();

            for (int i = 0; i < distinct.Count; i++)
            {
                var s = distinct[i];
                if (list.Count(x => x == s) % 2 == 1)
                {
                    list.RemoveAll(x => x == s);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
