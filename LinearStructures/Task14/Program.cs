using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 10;
            var m = 100;

            var lab = new string[n, m];
            var moves = new Stack<Pair>();
        }

        private void Step (Pair currentPoint, Stack<Pair> moves, string[,] lab)
        {
            var x = currentPoint.X;
            var y = currentPoint.Y;

            if (x+1<=lab.GetLength(0) && lab[x+1,y]== "0")
            {
                moves.Push(new Pair(x + 1, y));
                currentPoint = new Pair(x + 1, y);
                lab[x + 1, y] = "!";
                return;
            }

            if (x - 1 >=0 && lab[x - 1, y] == "0")
            {
                moves.Push(new Pair(x - 1, y));
                currentPoint = new Pair(x - 1, y);

                lab[x - 1, y] = "!";
                return;
            }

            if (y + 1 <= lab.GetLength(1) && lab[x, y+1] == "0")
            {
                moves.Push(new Pair(x, y+1));
                currentPoint = new Pair(x, y + 1);
                lab[x, y + 1] = "!";
                return;
            }

            if (y - 1 >=0 && lab[x, y - 1] == "0")
            {
                moves.Push(new Pair(x, y - 1));
                currentPoint = new Pair(x, y - 1);
                lab[x, y - 1] = "!";
                return;
            }

            currentPoint = moves.Pop();
        }

        private void Path (Pair startPoint, Pair goal, string[,] lab)
        {
            var moves = new Stack<Pair>();
            var labyrynth = lab;
            moves.Push(startPoint);

            var currentPoint = startPoint;

            while (currentPoint.X == goal.X && currentPoint.Y == goal.Y)
            {
                Step(currentPoint, moves, labyrynth);

                if(moves.Count == 0)
                {
                    break;
                }
            }

          
            if(moves.Count == 0)
            {
                lab[goal.X, goal.Y] = "u";
                return; 
            }

            lab[goal.X, goal.Y] = moves.Count.ToString();

        }
    }
}
