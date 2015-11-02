using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_9
{
    class Program
    {
        static void Main()
        {
            var n = 2;

            var queue = new Queue<int>();

            queue.Enqueue(n);

            var maxCount = 50;

            for (int i = 0; i < maxCount; i++)
            {
                var number = queue.Dequeue();
                Console.Write(number + " ");

                queue.Enqueue(number + 1);
                queue.Enqueue(2*number + 1);
                queue.Enqueue(number + 2);
            }
        }
    }
}
