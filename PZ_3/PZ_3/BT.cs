﻿using PZ_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3
{
    internal class BynaryTree
    {
        public Node Root { get; set; }

        public BynaryTree(int n)
        {
            Root = CreateBalancedTree(n);
        }

        public Node CreateBalancedTree(int n)
        {
            string text;
            Node root;

            if (n == 0)
                root = null;
            else
            {
                Console.WriteLine("Вводи, Родной");
                text = Console.ReadLine();

                root = new Node(text);
                root.Left = CreateBalancedTree(n / 2);
                root.Right = CreateBalancedTree(n - n / 2 - 1);
            }

            return root;
        }

        public static void GetTreeData(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Info);
                GetTreeData(root.Left);
                GetTreeData(root.Right);
            }
        }

        public static void AverageArif(Node root)
        {
            int count = Count(root);
            double sum = Sum(root);
            if (count != 0)
            {
                Console.WriteLine(sum / count);
            }
        }

        public static int Count(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return Count(root.Left) + 1 + Count(root.Right);
        }

        public static int Sum(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return Sum(root.Left) + Convert.ToInt32(root.Info) + Sum(root.Right);
        }

        public static int CountPlus(Node root)
        {
            int g = 0;

            if (root != null)
            {
                if ((Convert.ToInt32(root.Info) > 0)) g++;
                g += CountPlus(root.Left);
                g += CountPlus(root.Right);
            }
            return g;
        }
        public static int CountMinus(Node root)
        {
            int g = 0;

            if (root != null)
            {
                if ((Convert.ToInt32(root.Info) < 0)) g++;
                g += CountMinus(root.Left);
                g += CountMinus(root.Right);
            }
            return g;
        }

        public static int Countsverka(Node root, int n)
        {
            int g = 0;

            if (root != null)
            {
                if ((Convert.ToInt32(root.Info) == n)) g++;
                g += Countsverka(root.Left, n);
                g += Countsverka(root.Right, n);
            }
            return g;
        }
    }
}
