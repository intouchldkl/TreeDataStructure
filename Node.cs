using System;
using System.Collections.Generic;
using System.Text;

namespace TreeDataStructure
{
    class Node
    {
        public int num;
        public Node left;
        public Node right;

        public Node(int num,Node left,Node right)
        {
            this.num = num;
            this.left = left;
            this.right = right;
        }
    }
}
