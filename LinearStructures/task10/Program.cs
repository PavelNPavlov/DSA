using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            if (m < n)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            var sequence = new StringBuilder();
            sequence.Append(m.ToString());
            while (m!=n)
            {
                m = Step(m, n);
                sequence.Insert(0,m.ToString()+" -> ");
            }

            Console.WriteLine(sequence.ToString());
        }

        private static int Step(int m, int n)
        {
            
            if (m / 2 > n)
            {
                if (m % 2 != 0)
                {
                    return m - 1;
                }

                return m / 2;
            }

            if (m - 2 >= n)
            {
                return m - 2;
            }

            if (m - 1 >= n)
            {
                return m - 1;
            }

            return m;
        }
    }
}
