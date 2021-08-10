using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class MyBinaryNode<T> where T : IComparable
    {
        public INode<T> root;
        /// <summary>
        /// Insert the node into bst.
        /// </summary>
        /// <param name="value"></param>
        public void InsertNode(T value)
        {
            INode<T> newNode = new INode<T>(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                INode<T> parent = root;
                INode<T> current = root;
                while (true)
                {
                    parent = current;
                    if (current.data.CompareTo(value) >= 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Display the BST
        /// </summary>
        /// <param name="parent"></param>
        public void Display(INode<T> parent)
        {
            if (parent != null)
            {
                Display(parent.Left);
                Display(parent.Right);
                Console.WriteLine("{0} is BST Node", parent.data);
            }
        }
        /// <summary>
        /// Display the root node of BST.
        /// </summary>
        public void Root()
        {
            do
            {
                Console.WriteLine("BST Root Node:" + root.data);
                break;
            } while (root != null);
        }
        public int Size(INode<T> root)
        {
            if (root == null)
                return 0;
            else
                return Size(root.Left) + 1 + Size(root.Right);
        }

    }
}
