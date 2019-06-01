using System.Collections.Generic;

namespace DataStructures.Queues
{
    public class Queue<T> where T : class
    {
        private readonly LinkedList<T> list = new LinkedList<T>();

        public Queue()
        {
        }

        public Queue(T firstElement)
        {
            this.list.AddLast(firstElement);
        }

        public int Size() => this.list.Count;

        public bool IsEmpty() => this.list.Count == 0;

        public void Poll()
        {
            if (this.IsEmpty())
            {
                throw new System.Exception("Queue is empty");
            }

            this.list.RemoveFirst();
        }

        public void Offer(T element) => this.list.AddLast(element);
    }
}
