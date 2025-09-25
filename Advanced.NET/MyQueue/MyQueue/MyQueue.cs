using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    internal class MyQueue <T>
    {
        private List<T> _list = new List<T> ();

        public MyQueue ()
        {
            //_list = new List<T> ();
        }

        public void Add (T item)
        {
            _list.Add (item);
        }

        public T? Remove ()
        {
            if (_list.Count != 0)
            {
                T item = _list[0];
                _list.RemoveAt (0);
                return item;
            }
            return default;
            
            
        }

        public T? peek()
        {
            if (_list.Count != 0)
            {
                T item = _list[0];
                return item;
            }
            return default;
        }

        
    }
}
