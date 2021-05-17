using System;
using System.Collections.Generic;
using System.Text;

namespace TreeDataStructure
{
    class Tree
    {
        public Node root = null;

        public Tree()
        {

        
        }

        public void Add(int num)
        {
            Node newNode = new Node(num, null, null);
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                while(current != null)
                {
                    if(num > current.num)
                    {
                        if(current.right == null)
                        {
                            current.right = newNode;
                            return;
                        }
                        current = current.right;
                    }
                    else if(num < current.num)
                    {
                        if (current.left == null)
                        {
                            current.left = newNode;
                            return;
                        }
                        current = current.left;
                    }
                    else
                    {
                        return;
                    }


                }
            }

            
        }
        public bool find(int num)
        {
            Node current = root;
            bool found = false;
            while(current != null)
            {
                if(num > current.num)
                {
                    current = current.right;
                }
                else if(num < current.num)
                {
                    current = current.left;
                }
                else if(num == current.num)
                {
                    found = true;
                    break;
                }
             }
            return found;
        }

        public void printAll ()
        {
             Node current = root;
            if (current == null)
                return;
            Console.WriteLine(current.num);
            RepeatPrint(current.left);
            RepeatPrint(current.right);
        }
        public void RepeatPrint(Node current)
        {
            
            if (current == null)
                return;
            Console.WriteLine(current.num);
            RepeatPrint(current.left);
            RepeatPrint(current.right);
        }
    }
}
