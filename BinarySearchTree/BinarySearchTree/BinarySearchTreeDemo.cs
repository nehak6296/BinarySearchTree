﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTreeDemo<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTreeDemo<T> leftTree { get; set; }
        public BinarySearchTreeDemo<T> rightTree { get; set; }

        public BinarySearchTreeDemo(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;

        }

        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTreeDemo<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTreeDemo<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }


        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();

            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
    }
}
