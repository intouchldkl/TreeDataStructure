using System;

namespace TreeDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree();

            myTree.Add(1);
            myTree.Add(2);
            myTree.Add(3);
            myTree.Add(4);
            myTree.Add(5);
            myTree.Add(6);
            myTree.Add(7);

            Console.WriteLine(myTree.find(1));
            Console.WriteLine(myTree.find(2));
            Console.WriteLine(myTree.find(3));
            Console.WriteLine(myTree.find(4));
            Console.WriteLine(myTree.find(5));
            Console.WriteLine(myTree.find(6));
            Console.WriteLine(myTree.find(7));
            Console.WriteLine(myTree.find(8));
            Console.WriteLine(myTree.find(0));

            myTree.printAll();
        }
    }
}
