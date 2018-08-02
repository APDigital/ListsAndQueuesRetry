using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueuesRetry
{
    class DoubleLinkedList
    {
        private DoubleLink first;
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
            if (first == null)
            {
                first.PreviousNode = link;
                first = link;

            }
            return link;
        }
        public DoubleLink Delete()
        {
            DoubleLink firstLink = first;
            if (first != null)
            {
                first = first.NextNode;
                if (first != null)
                {
                    first.PreviousNode = null;
                }
            }
            return firstLink;
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
        public void InsertAfter(DoubleLink link, string node)
        {
            if (link == null || string.IsNullOrEmpty(node))
            {
                return;
            }
            DoubleLink newLink = new DoubleLink(node);
            newLink.PreviousNode = link;

            if (link.NextNode != null)
            {
                link.NextNode = link;
            }
            else
            {
                newLink.NextNode = link.NextNode;
                link.NextNode = newLink;
            }
        }
    }
}
