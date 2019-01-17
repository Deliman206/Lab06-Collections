using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Collections.Classes
{
    class Decks<T> : IEnumerable<T>
    {
        T[] items = new T[13];
        int currentIndex = 0;

        public void Add(T item)
        {
            if (currentIndex > items.Length - 1)
            {
                Array.Resize(ref items, items.Length + 13);
            }
            items[currentIndex] = item;
            currentIndex += 1;
        }

        public T Remove(T item)
        {
            int nullCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if(item.Equals(items[i]))
                {
                    // A default value expression default(T) produces the default value 
                    //of a type T. 
                    //The following table shows which values are produced for various types:
                    // ANy refernece Type = null

                    items[i] = default;
                }
                if (items[i] == null)
                {
                    nullCount += 1;
                }
                if (nullCount >= 13)
                {
                    Array.Resize(ref items, items.Length - 13);
                }
            }
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
