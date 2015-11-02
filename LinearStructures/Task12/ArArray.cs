using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    public class Stack<T>
    {
        private int capacity;
        private int lastIndex;

        private T[] values;

        public Stack()
        {
            this.capacity = 16;
            this.lastIndex = -1;
            values = new T[this.capacity];
        }

        public void Push(T value)
        {
            this.lastIndex++;
            if(lastIndex >= 3*this.capacity/4)
            {
                this.Resize();
            }
            values[this.lastIndex] = value;
        }

        public T Pop()
        {
            var value = this.values[lastIndex];
            this.values[lastIndex] = default(T);
            this.lastIndex--;
            return value;
        }

        private void Resize()
        {
            this.capacity *= 2;
            var newArray = new T[this.capacity];

            for (int i = 0; i < this.values.Length; i++)
            {
                newArray[i] = this.values[i];
            }

            this.values = newArray;
        }

    }
}
