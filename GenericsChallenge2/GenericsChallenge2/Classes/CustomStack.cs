using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsChallenge2.Classes
{
    internal class CustomStack<T> : IEnumerable<T>
    {
        public T[] Items { get; private set; }

        public CustomStack(T[] items)
        {
            Items = items;
        }

        public void Push(T item)
        {
            T[] temp = new T[0];
            Array.Copy(Items, temp, Items.Length + 1);
            temp[^1] = item;
            Items = temp;
        }
        public void Pop()
        {
            T[] temp = new T[Items.Length - 1];

            for (int i = 0; i < Items.Length - 1; i++)
            {
                temp[i] = Items[i];
            }
            Items = temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)Items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
