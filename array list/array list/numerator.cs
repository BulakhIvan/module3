using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    public class CustomList<T> : IEnumerable<T>
    {
        public T[] _items;
        public CustomList()
        {
            _items = new T[] { };
        }
        public void Add(T item)
        {
            var itemsCount = _items.Length;
            var extendedItems = new T[itemsCount +1];
            _items.CopyTo(extendedItems, 0);
            extendedItems[itemsCount] = item;
            _items = extendedItems;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new CustomEnumerator<T>(_items);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        internal class CustomEnumerator<T> : IEnumerator<T>
        {
            private T[] _items;
            private int _position = -1;
            public T Current {
                get
                {
                    try {
                        return _items[_position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOprationException();
                    }
                }
            }
            object IEnumerator.Current => Current;
            public void Dispose() { }
            public bool MoveNext()
            {
                _position++;
                return (_position < _items.Length);
            }
            public void Reset()
            {
                _position = -1;
            }
        }
    }  
}