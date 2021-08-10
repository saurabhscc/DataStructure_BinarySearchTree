using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class MyBinaryNode<T> where T : IComparable
    {
        public INode<T> value;
        public INode<T> start;
        public MyBinaryNode()
        {
            value = null;
            start = null;
        }
        public void Add(T data)
        {
            if (value == null)
            {
                value = new INode<T>(data);
            }
            else
            {
                var node = new INode<T>(data);
                var temp = start;
                if (data.CompareTo(value.data) < 0)
                {
                    if (temp.Left == null)
                        temp.Left = node;
                    else
                    {
                        start = temp.Left;
                        Add(data);
                    }
                }
                else
                {
                    if (temp.Right == null)
                        temp.Right = node;
                    else
                    {
                        start = temp.Right;
                        Add(data);
                    }
                }
            }
            start = value;
        }
        public void Display(INode<T> parent)
        {
            Console.WriteLine("Parent : {0}", parent.data);
            if (parent.Left != null)
            {
                Console.WriteLine("Left :" + parent.Left.data);
            }
            if (parent.Right != null)
                Console.WriteLine("Right :" + parent.Right.data);
            if (parent.Left != null)
            {
                Display(parent.Left);
            }
            if (parent.Right != null)
            {
                Display(parent.Right);
            }
        }
    }
}
