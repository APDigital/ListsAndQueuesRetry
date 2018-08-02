using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListsAndQueuesRetry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueuesRetry.Tests
{
    [TestClass()]
    public class DoubleLinkedListTests
    {
        DoubleLinkedList list = new DoubleLinkedList();
        DoubleLinkedList empty = new DoubleLinkedList();
        string insertNodeValue = "test";
        [TestMethod()]
        public void InsertTest()
        {
            DoubleLink testList = list.Insert(insertNodeValue);

            Assert.AreEqual(testList.Node, "test");
        }

        [TestMethod()]
        public void DeleteTest()
        {
            list.Delete("test");
            Assert.AreEqual(list.IsEmpty, empty.IsEmpty);
        }

        [TestMethod()]
        public void InsertAfterTest()
        {
            DoubleLink currentLink = new DoubleLink(insertNodeValue);
            DoubleLink insertLink = new DoubleLink("test2");
            list.InsertAfter(list, insertLink, currentLink);
            Assert.IsNotNull(list);
        }
    }
}