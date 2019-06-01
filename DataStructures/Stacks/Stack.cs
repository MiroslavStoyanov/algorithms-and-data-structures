using System;
using System.Collections.Generic;

namespace DataStructures.Stacks
{
    public class Stack<T> where T : class
    {
        private readonly LinkedList<T> list = new LinkedList<T>();

        public Stack()
        {
        }

        public Stack(T firstElement)
        {
            this.Push(firstElement);
        }

        public bool IsEmpty() => this.list.Count == 0;

        public int Size() => this.list.Count;

        public void Push(T element) => this.list.AddLast(element);

        public void Pop()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Stack is empty");
            }

            this.list.RemoveLast();
        }
    }
}
