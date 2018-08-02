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
    public class SimpleLinkedListTests
    {
        LinkedList<string> list = new LinkedList<string>();
        SimpleLinkedList simpleLinkedList = new SimpleLinkedList();
        [TestMethod()]
        public void GetLinkedListTest()
        {
            simpleLinkedList.GetLinkedList(list, "test");
            Assert.IsNotNull(simpleLinkedList);
        }
    }
}