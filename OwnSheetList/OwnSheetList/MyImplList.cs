using System;
using System.Collections.Generic;
using System.Text;

namespace OwnSheetList
{
    public class MyImplList<T> : List<T>
    {
        private Node<T> node;
        private int size = 0;

        public MyImplList()
        {
            this.node = new Node<T>();
        }

        public int Size() => 0;
        public bool IsEmpty() => false;
        public bool Contains(object o) => false;
        public IEnumerator<T> Iterator() => null;
        public new object[] ToArray() => new object[0];
        public T[] ToArray(T[] a) => null;
        public new bool Add(T t) => false;
        public bool Remove(object o) => false; 
        //public bool ContainsAll(Predicate<?> c)=>

    }
}
