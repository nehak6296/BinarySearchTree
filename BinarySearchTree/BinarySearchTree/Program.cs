using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Demo!");
            BinarySearchTreeDemo<int> binarSearchTree = new BinarySearchTreeDemo<int>(56);
            binarSearchTree.Insert(30);
            binarSearchTree.Insert(70);
            binarSearchTree.Display();
        }
    }
}
