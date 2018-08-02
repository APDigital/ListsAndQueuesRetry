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
    public class SingleLinkedListTests
    {
        SingleLinkedList list = new SingleLinkedList();
        string testNode = "test";
        [TestMethod()]
        public void AddToLinkedListTest()
        {
            list.AddToLinkedList(testNode);
            Assert.AreEqual(list.First.CurrentValue,"test");
        }

        [TestMethod()]
        public void DisplayAllItemsTest()
        {
            list.AddToLinkedList("test");
            list.AddToLinkedList("test2");
            list.AddToLinkedList("test3");
            list.DisplayAllItems();

            Assert.IsNotNull(list);
        }
    }
}