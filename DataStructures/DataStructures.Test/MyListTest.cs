using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DataStructures.Test
{
    [TestClass]
    public class MyListTest
    {
        [TestMethod]
        public void should_Create_MyList_Instance()
        {
            var myList = new MyList();
            Assert.IsNotNull(myList);
        }

        [TestMethod]
        public void should_Add_Single_Item_To_MyList_Instance()
        {
            var myList = new MyList();
            myList.Add(1);
            Assert.AreEqual(1,myList.Count);
            Assert.AreEqual(1,myList.Capacity);
        }

        [TestMethod]
        public void should_Add_Multiple_Items_To_MyList_Instance()
        {
            var myList = new MyList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            Assert.AreEqual(6,myList.Count);
            Assert.AreEqual(6,myList.Capacity);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void should_Throw_Exception_Inserting_Single_Item_In_MyList_Instance_Without_Capacity()
        {
            var myList = new MyList();
            myList.Add(1);
            myList.Add(3);
            myList.Insert(3,4);
        }

        [TestMethod]
        public void should_Insert_Single_Item_In_MyList_Instance()
        {
            var myList = new MyList();
            myList.Add(1);
            myList.Add(3);
            myList.Insert(1,2);

            Assert.AreEqual(3, myList.Count);
            Assert.AreEqual(3, myList.Capacity);
        }

        [TestMethod]
        public void should_Insert_Multiple_Items_In_MyList_Instance()
        {
            var myList = new MyList();
            myList.Add(2);
            myList.Add(4);
            myList.Insert(1,3);
            myList.Insert(0,1);

            Assert.AreEqual(4, myList.Count);
        }

        [TestMethod]
        public void should_Retrieve_Array_With_Multiple_Items_In_MyList_Instance()
        {
            var expectedResult = new [] { 4, 2, 1, 3, 9, 10 };
            var myList = new MyList();
            myList.Add(4);
            myList.Add(2);
            myList.Add(1);
            myList.Add(3);
            myList.Add(9);
            myList.Add(10);
            var actualResult = myList.ToArray();

            var result = expectedResult.SequenceEqual(actualResult);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void should_Sort_Multiple_Items_In_MyList_Instance()
        {
            var expectedResult = new[] { 1, 2, 3, 4, 9, 10 };
            var myList = new MyList();
            myList.Add(4);
            myList.Add(2);
            myList.Add(1);
            myList.Add(3);
            myList.Add(9);
            myList.Add(10);

            myList.Sort();
            var actualResult = myList.ToArray();
            Assert.IsTrue(expectedResult.SequenceEqual(actualResult));
        }

        [TestMethod]
        public void should_Get_Item_At_Index_From_MyList_Instance()
        {
            var myList = new MyList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            var result = myList[4];
            Assert.AreEqual(5, result);
        }
    }
}
