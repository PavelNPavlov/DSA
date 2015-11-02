using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    public class Que<T>
    {
        private LinkedList<T> values;

        public Que()
        {
            this.values = new LinkedList<T>();
        }

        public void Enqueue(T value)
        {
            this.values.AddLast(value);
        }

        public T Dequeue()
        {
            var first = this.values.First;
            this.values.RemoveFirst();

            return first.Value;
        }
    }
}
