using System;

namespace DataStructures.Test
{
    public class MyQueue<T>
    {
        protected class Node
        {
            public Node Next { get; set; }

            public T Value { get; private set; }
            
            protected internal Node(T item)
            {
                Value = item;
            }
        }
        public class MyQueueException : Exception
        {
            public MyQueueException(string message) : base(message) { }
        }

        private Node FirstNode { get; set; }
        private Node LastNode { get; set; }
        public int Count { get; private set; }

        public void Enqueue(T item)
        {
            var newNode = new Node(item);
            if (FirstNode == null)
            {    
                FirstNode = LastNode = newNode;
            }
            else
            {
                LastNode.Next = newNode;
                LastNode = newNode;
            }
            Count++;
        }

        public T Dequeue()
        {
            T result;
            if (Count == 0)
                throw new MyQueueException("There are no items in the queue to remove");
            
            if (FirstNode == LastNode)
            {
                result = FirstNode.Value;
                FirstNode = null;
                LastNode = null;
            }
            else
            {
                result = FirstNode.Value;
                FirstNode = FirstNode.Next;
            }
            Count--;

            return result;
        }
    }
}