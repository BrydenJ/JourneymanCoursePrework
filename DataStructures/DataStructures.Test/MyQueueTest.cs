using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Test
{
    [TestClass]
    public class MyQueueTest
    {
        [TestMethod]
        public void Should_Create_MyQueue_Instance()
        {
            var myQueue = new MyQueue<object>();
            Assert.IsNotNull(myQueue);
        }

        [TestMethod]
        public void Should_Enqueue_Single_Item_To_MyQueue_Instance()
        {
            var myQueue = new MyQueue<object>();
            myQueue.Enqueue(new object());
            Assert.AreEqual(1, myQueue.Count);
        }

        [TestMethod]
        public void Should_Enqueue_Multiple_Items_To_MyQueue_Instance()
        {
            var myQueue = new MyQueue<object>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            Assert.AreEqual(4, myQueue.Count);
        }

        [TestMethod]
        public void Should_Dequeue_Single_Item_From_MyQueue_Instance()
        {
            var myQueue = new MyQueue<object>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            var dequeueResult = myQueue.Dequeue();
            
            myQueue.Enqueue(4);
            Assert.AreEqual(3, myQueue.Count);
            Assert.AreEqual(1, dequeueResult);
        }

        [TestMethod]
        public void Should_Dequeue_All_Items_From_MyQueue_Instance()
        {
            var myQueue = new MyQueue<object>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            var dequeueResult1 = myQueue.Dequeue();
            var dequeueResult2 = myQueue.Dequeue();
            var dequeueResult3 = myQueue.Dequeue();
            Assert.AreEqual(1, dequeueResult1);
            Assert.AreEqual(2, dequeueResult2);
            Assert.AreEqual(3, dequeueResult3);
            
            Assert.AreEqual(0, myQueue.Count);
        }

        [TestMethod, 
         ExpectedException(typeof(MyQueue<object>.MyQueueException))]
        public void Should_Get_MyQueueException_When_Dequeueing_From_Empty_MyQueue_Instance()
        {
            var myQueue = new MyQueue<object>();
            myQueue.Dequeue();
        }
    }
}
