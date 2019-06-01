namespace DataStructures.LinkedLists
{
    public class DoublyLinkedList<T> where T : class
    {
        private int size = 0;
        private Node<T> head = null;
        private Node<T> tail = null;

        private class Node<T>
        {
            internal T Data;
            internal Node<T> Prev;
            internal Node<T> Next;

            public Node(T data, Node<T> prev, Node<T> next)
            {
                this.Data = data;
                this.Prev = prev;
                this.Next = next;
            }

            public string ToString() => this.Data.ToString();
        }

        public void Clear()
        {
            Node<T> trav = this.head;

            while (trav != null)
            {
                Node<T> next = trav.Next;
                trav.Prev = trav.Next = null;
                trav.Data = null;
                trav = next;
            }

            this.head = this.tail = null;
            this.size = 0;
        }

        public int Size() => this.size;

        public bool IsEmpty() => this.Size() == 0;

        public void AddLast(T element)
        {
            if (this.IsEmpty())
            {
                this.head = this.tail = new Node<T>(element, null, null);
            }
            else
            {
                this.tail.Next = new Node<T>(element, this.tail, null);
                this.tail = this.tail.Next;
            }

            this.size++;
        }

        public void AddFirst(T element)
        {
            if (this.IsEmpty())
            {
                this.head = this.tail = new Node<T>(element, null, null);
            }
            else
            {
                this.head.Prev = new Node<T>(element, null, this.head);
                this.head = this.head.Prev;
            }

            this.size++;
        }

        public T PeekFirst()
        {
            if (this.IsEmpty())
            {
                throw new System.Exception("Empty list");
            }

            return this.head.Data;
        }

        public T PeekLast()
        {
            if (this.IsEmpty())
            {
                throw new System.Exception("Empty list");
            }

            return this.tail.Data;
        }

        public T RemoveFirst()
        {
            if (this.IsEmpty())
            {
                throw new System.Exception("Empty list");
            }

            T data = this.head.Data;
            this.head = this.head.Next;

            this.size--;

            if (this.IsEmpty())
            {
                this.tail = null;
            }
            else
            {
                this.head.Prev = null;
            }

            return data;
        }

        public T RemoveLast()
        {
            if (this.IsEmpty())
            {
                throw new System.Exception("Empty list");
            }

            T data = this.tail.Data;
            this.tail = this.tail.Prev;

            this.size--;

            if (this.IsEmpty())
            {
                this.head = null;
            }
            else
            {
                this.tail.Next = null;
            }

            return data;
        }
    }

}
