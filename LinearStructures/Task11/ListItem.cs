using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public class ListItem<T>
    {
        private T value;
        private ListItem<T> nextItem;

        public ListItem(T value)
        {
            this.value = value;
            this.nextItem = null;
        }

        public T Value { get { return value; } }
        public ListItem<T> NextItem { get { return nextItem; } }
    }
}
