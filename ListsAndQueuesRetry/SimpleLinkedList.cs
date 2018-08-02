using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueuesRetry
{
    class SimpleLinkedList
    {
        public void GetLinkedList(LinkedList<string> linkedList, string data)
        {
            linkedList.AddLast("one");
            linkedList.AddLast("two");
            linkedList.AddLast("three");

            LinkedListNode<string> linkedListNode = linkedList.Find("one");
            linkedList.AddAfter(linkedListNode, data);

            foreach (var value in linkedList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
