using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    public class array_list<T> : IEnumerable<T> 
    {
        public IEnumerator<T> GetEnumerator()
        {
            return new MyCustomEnumerator<T>();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(T item)
        {
            throw new NotImplementedException();
        }
        public void AddRange(T[] items)
        {
            throw new NotImplementedException();
        }
        public void Remove(T item)
        {
            throw new NotImplementedException();
        }
        public void RemoveAt(int itemIndex)
        {
            throw new NotImplementedException();
        }
        public void Sort()
        {
            throw new NotImplementedException();
        } 

        internal class MyCusyomEnumerator<T> : IEnumerator<T>
        {
            public T Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
            object IEnumerator.Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
            public void Dispose() { }
            public bool MoveNext()
            {
                throw new NotImplementedException();
            }
            public void Reset()
            {
                throw new NotImplementedException();
            }

        }
    }
}
