using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            var stack = new Stack<int>();

            while (true)
            {
                input = Console.ReadLine();
                if(input == string.Empty)
                {
                    break;
                }
                stack.Push(int.Parse(input));

            }

            foreach (var item in stack)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
