using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class INode<T> where T : IComparable
    {
        public T data;
        public INode<T> Left;
        public INode<T> Right;
        public INode(T data)
        {
            this.data = data;
            Left = null;
            Right = null;
        }
    }
}
