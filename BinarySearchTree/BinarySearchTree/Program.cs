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
            binarSearchTree.Insert(22);
            binarSearchTree.Insert(40);
            binarSearchTree.Insert(60);
            binarSearchTree.Insert(95);
            binarSearchTree.Insert(11);
            binarSearchTree.Insert(65);
            binarSearchTree.Insert(3);
            binarSearchTree.Insert(16);
            binarSearchTree.Insert(63);
            binarSearchTree.Insert(67);            
            binarSearchTree.Display();
            binarSearchTree.GetSize();
            Console.ReadKey();
        }
    }
}
