using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //BinaryTree binaryTree = new BinaryTree();

            //binaryTree.Add(1);
            //binaryTree.Add(2);
            //binaryTree.Add(7);
            //binaryTree.Add(3);
            //binaryTree.Add(10);
            //binaryTree.Add(5);
            //binaryTree.Add(8);

            //Node node = binaryTree.Find(5);
            //if (node != null)
            //{
            //    Console.WriteLine("Đã tìm thấy node có giá trị bằng 5!");
            //}
            //else
            //{
            //    Console.WriteLine("Không tìm thấy node!");
            //}
            //int depth = binaryTree.GetTreeDepth();

            //Console.WriteLine("PreOrder Traversal:");
            //binaryTree.TraversePreOrder(binaryTree.Root);
            //Console.WriteLine();

            //Console.WriteLine("InOrder Traversal:");
            //binaryTree.TraverseInOrder(binaryTree.Root);
            //Console.WriteLine();

            //Console.WriteLine("PostOrder Traversal:");
            //binaryTree.TraversePostOrder(binaryTree.Root);
            //Console.WriteLine();

            //binaryTree.Remove(7);
            //binaryTree.Remove(8);

            //Console.WriteLine("PreOrder Traversal After Removing Operation:");
            //binaryTree.TraversePreOrder(binaryTree.Root);
            //Console.WriteLine();

            //Console.ReadLine();

            DateTime currentTime = DateTime.Now.Date;

            DateTime deadline = currentTime.AddMonths(1).Date;

            string current = currentTime.ToString("yyyy-dd-MM");
            string end = deadline.ToString("yyyy-dd-MM");

            Console.WriteLine(current + " " + end);


        }
    }
}
