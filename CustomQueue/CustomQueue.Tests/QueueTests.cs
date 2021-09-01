using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CS = CustomQueue.Tests.Objects;

namespace CustomQueue.Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void QueueThreeItemsTest()
        {
            //Arrange
            Queue<int> queue = new Queue<int>();

            //Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            int item1 = queue.Dequeue();
            int item2 = queue.Dequeue();
            int item3 = queue.Dequeue();

            //Assert
            Assert.AreEqual(1, item1);
            Assert.AreEqual(2, item2);
            Assert.AreEqual(3, item3);
        }

        [TestMethod]
        public void Queue500ItemsListTest()
        {
            //Arrange
            Queue<int> queue;
            List<int> list = new List<int>();

            //Act
            for (int i = 0; i < 500; i++)
            {
                list.Add(i);
            }
            queue = new Queue<int>(list);

            //Assert
            Assert.AreEqual(500, queue.Count);

            for (int i = 0; i < 500; i++)
            {
                queue.Dequeue();
            }
            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void CustomQueueThreeItemsTest()
        {
            //Arrange
            CS.CustomQueue queue = new CS.CustomQueue();

            //Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            int item1 = queue.Dequeue();
            int item2 = queue.Dequeue();
            int item3 = queue.Dequeue();

            //Assert
            Assert.AreEqual(1, item1);
            Assert.AreEqual(2, item2);
            Assert.AreEqual(3, item3);
        }

        [TestMethod]
        public void NewQueue500ItemsListTest()
        {
            //Arrange
            CS.CustomQueue queue;
            List<int> list = new List<int>();

            //Act
            for (int i = 0; i < 500; i++)
            {
                list.Add(i);
            }
            queue = new CS.CustomQueue(list);

            //Assert
            Assert.AreEqual(500, queue.Count);
        }

    }
}
