using System;

namespace BinarySearchTree
{
    class Program
    {
        static readonly MyBinaryNode<int> mybinarynode = new MyBinaryNode<int>();
        public static void BSTView()
        {
            mybinarynode.InsertNode(56);
            mybinarynode.InsertNode(30);
            mybinarynode.InsertNode(70);
            mybinarynode.Display(mybinarynode.root);
            mybinarynode.Root();
            
        }
        static void Main(string[] args)
        {
            BSTView();
        }
    }
}

