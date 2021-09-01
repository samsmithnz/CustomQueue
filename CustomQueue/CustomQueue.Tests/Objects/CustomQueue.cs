using System.Collections.Generic;

namespace CustomQueue.Tests.Objects
{
    public class CustomQueue
    {
        public List<int> Queue;

        //initialize an empty queue
        public CustomQueue()
        {
            Queue = new List<int>();
        }

        //initalize with a new list
        public CustomQueue(List<int> list)
        {
            Queue = list;
        }

        //pick the first item off the list
        public int Dequeue()
        {
            int result = Queue[0];
            Queue.RemoveAt(0);
            return result;
        }

        //add a new item to the end of the list
        public void Enqueue(int i)
        {
            Queue.Add(i);
        }

        public int Count
        {
            get
            {
                return Queue.Count;
            }
        }
    }
}


