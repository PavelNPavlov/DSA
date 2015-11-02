using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public class LnkList<T>
    {
        private ListItem<T> firstElement;

        public LnkList()
        {
            this.firstElement = null;
        }

        public ListItem<T> FirstElement { get; private set; }

        public void Add(ListItem<T> listItem)
        {
            var item = this.firstElement;

            while (item != null)
            {
                item = item.NextItem;
            }

            item = listItem;
        }

        public ListItem<T> Contains(T value)
        {
            var item = this.firstElement;

            while (!item.Value.Equals(value))
            {
                item = item.NextItem;
                if (item == null)
                {
                    throw new ArgumentException("Not Presnet");
                }
            }

            return item;
        }

        public ListItem<T> Contains(ListItem<T> lItem)
        {
            var item = this.firstElement;

            while (!item.Equals(lItem))
            {
                item = item.NextItem;
                if (item == null)
                {
                    throw new ArgumentException("Not Presnet");
                }
            }

            return item;
        }

        public void Remove(ListItem<T> lItem)
        {
            var item = this.firstElement;

            while (!item.Equals(lItem))
            {
                item = item.NextItem;
                if (item == null)
                {
                    throw new ArgumentException("Not Presnet");
                }
            }

            item = null;
        }

        public void Remove(T value)
        {
            var item = this.firstElement;

            while (!item.Value.Equals(value))
            {
                item = item.NextItem;
                if (item == null)
                {
                    throw new ArgumentException("Not Presnet");
                }
            }

            item = null;
        }

    }
}
