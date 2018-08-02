using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueuesRetry
{
    public class DoubleLink
    {
        public string Node { get; set; }
        public DoubleLink PreviousNode { get; set; }
        public DoubleLink NextNode { get; set; }

        public DoubleLink(string node)
        {
            Node = node;
        }
        public override string ToString()
        {
            return Node;
        }
    }
}
