using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditation
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split(' ');

            var m = new Queue<string>();
            var k = new Queue<string>();
            var p = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                var type = input[i][0];
                switch (type)
                {
                    case 'm':
                        m.Enqueue(input[i]);
                        break;
                    case 'k':
                        k.Enqueue(input[i]);
                        break;
                    case 'p':
                        p.Enqueue(input[i]);
                        break;
                    default:
                        break;
                }
            }

            var result = new StringBuilder();

            for (int i = 0, l = m.Count; i < l; i++)
            {
                result.Append(m.Dequeue() +" ");
            }
            for (int i = 0, l = k.Count; i < l; i++)
            {
                result.Append(k.Dequeue() + " ");
            }
            for (int i = 0, l = p.Count; i < l; i++)
            {
                result.Append(p.Dequeue() + " ");
            }

            Console.WriteLine(result.ToString());
        }
    }
}
