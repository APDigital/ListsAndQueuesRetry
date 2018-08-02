using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueuesRetry
{
    public class DoubleLinkedList
    {
        public DoubleLink first;
        public bool IsEmpty
        {
            get
            {
                return first == null;
            }
        }
        public DoubleLinkedList()
        {
            first = null;
        }
        public DoubleLink Insert(string node)
        {
            DoubleLink link = new DoubleLink(node);
            link.NextNode = first;
            if (first != null)
            {
                first.PreviousNode = link;
                first = link;
            }

            return link;
        }
        public DoubleLink Delete(string deleteItem)
        {
            DoubleLink doubleLinkDelete = new DoubleLink(deleteItem);
            first = doubleLinkDelete;
            if (first != null)
            {
                first = first.NextNode;
                if (first != null)
                {
                    first.PreviousNode = null;
                }
            }
            return first;
        }
        public override string ToString()
        {
            DoubleLink currentLink = first;
            StringBuilder str = new StringBuilder();
            while (currentLink != null)
            {
                str.Append(currentLink);
                currentLink = currentLink.NextNode;
            }
            return str.ToString();
        }
        public void InsertAfter(DoubleLinkedList list, DoubleLink insertLink, DoubleLink currentLink)
        {
            if (first == null)
            {
                list.Insert(currentLink.Node);
            }
            list.Insert(insertLink.Node);
            currentLink.NextNode = insertLink;
            insertLink.PreviousNode = currentLink;

            
        }
    }
}
