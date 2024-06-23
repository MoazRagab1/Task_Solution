using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            this.data = data;
            this.Next = null;
        }

    }
}
