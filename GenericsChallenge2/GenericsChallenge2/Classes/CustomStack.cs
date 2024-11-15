using System.Collections;

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
            T[] temp = new T[Items.Length + 1];
            Array.Copy(Items, temp, Items.Length);
            temp[^1] = item;
            Items = temp;
        }
        public void Pop()
        {
            T[] temp = new T[Items.Length - 1];
            Array.Copy(Items, temp, Items.Length - 1);
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
