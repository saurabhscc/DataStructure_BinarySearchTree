using System;

namespace BinarySearchTree
{
    class Program
    {
        
        public static void BinarySearchTree()
        {
            Console.WriteLine("Welcome to the Binary Search Tree program");

            var bst = new MyBinaryNode<int>();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);
            bst.Display(bst.value);
        }
        static void Main(string[] args)
        {
            BinarySearchTree();
        }
    }
}
