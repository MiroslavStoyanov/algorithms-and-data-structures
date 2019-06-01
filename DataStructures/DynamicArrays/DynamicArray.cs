using System;

namespace DataStructures.DynamicArrays
{
    public class DynamicArray<T> where T : class
    {
        private T[] array;
        private int length = 0;
        private int capacity = 0;

        public DynamicArray(int capacity)
        {
            if (this.capacity == 0)
            {
                throw new NullReferenceException("Capacity is" + this.capacity);
            }

            this.capacity = capacity;
            this.array = (T[]) new object[capacity];
        }

        public int Size() => this.length;

        public bool IsEmpty() => this.Size() == 0;

        public T Get(int index) => this.array[index];

        public void Set(int index, T element) => this.array[index] = element;

        public void Clear()
        {
            for (int i = 0; i < this.length; i++)
            {
                this.array[i] = null;
            }

            this.length = 0;
        }

        public void Add(T element)
        {
            if (this.length + 1 >= this.capacity)
            {
                if (this.capacity == 0)
                {
                    this.capacity = 1;
                }
                else
                {
                    this.capacity += 2;
                }

                var newArray = (T[]) new object[this.capacity];

                for (int i = 0; i < this.length; i++)
                {
                    this.array[i] = newArray[i];
                }

                this.array = newArray;
            }

            this.array[this.length++] = element;
        }

        public T RemoveAt(int removeIndex)
        {
            if (removeIndex >= this.length || removeIndex < 0)
            {
                throw new Exception("Invalid index");
            }

            T data = this.array[removeIndex];
            var newArray = (T[]) new object[this.length - 1];

            for (int i = 0, j = 0; i < this.length; i++, j++)
            {
                if (i == removeIndex)
                {
                    j--;
                }
                else
                {
                    newArray[j] = this.array[i];
                }
            }

            this.array = newArray;
            this.capacity = --this.length;

            return data;
        }
    }
}
