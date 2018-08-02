using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueuesRetry
{
    public class SingleLinkedList
    {
        public Node First { get; set; }
        public Node Last { get; set; }

        public void AddToLinkedList(string value)
        {
            Node node = new Node();
            node.CurrentValue = value;

            if (First == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.NextNode = node;
                Last = node;
            }
        }

        public void DisplayAllItems()
        {
            Node currentNode = First;
            Console.WriteLine("List: ");
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.CurrentValue);
                currentNode = currentNode.NextNode;
            }
        }
    }
    public class Node
    {
        public string CurrentValue { get; set; }
        public Node NextNode { get; set; }
    }
}
