using System;
using System.Collections.Generic;
using System.Text;

namespace OwnSheetList
{
    /// <summary>
    /// Элемента очереди
    /// </summary>
    /// <param>Node next – тут мы будем хранить адрес следующего элемента коллекции;</param>
    /// <param>Node previous – тут мы будем хранить адрес предыдущего элемента коллекции;</param>
    /// <param>T t – это наш item;</param>
    /// <param>int index – тут индекс текущего элемента коллекции.</param>
    public class Node<T>
    {
        private Node<T> next;
        private Node<T> previous;
        private T t;
        public Node()
        {
            this.next = null;
            this.previous = null;
        }

        public Node(Node<T> previous)
        {
            this.next = null;
            this.previous = previous;
        }

        public Node<T> GetNext() => next;
        public void SetNext(Node<T> next)=> this.next = next;
        public Node<T> GetPrevious()=> previous;
        public void SetPrevious(Node<T> previous)=> this.previous = previous;
        public T GetT() => t;
        public void SetT(T t) => this.t = t;
    }
}
