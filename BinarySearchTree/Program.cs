﻿using System;

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
            mybinarynode.InsertNode(22);
            mybinarynode.InsertNode(40);
            mybinarynode.InsertNode(60);
            mybinarynode.InsertNode(95);
            mybinarynode.InsertNode(11);
            mybinarynode.InsertNode(65);
            mybinarynode.InsertNode(3);
            mybinarynode.InsertNode(16);
            mybinarynode.InsertNode(63);
            mybinarynode.InsertNode(67);
            mybinarynode.Display(mybinarynode.root);
            mybinarynode.Root();
            Console.WriteLine("The number of nodes in BST:{0}", mybinarynode.Size(mybinarynode.root));

        }
        static void Main(string[] args)
        {
            BSTView();
        }
    }
}

