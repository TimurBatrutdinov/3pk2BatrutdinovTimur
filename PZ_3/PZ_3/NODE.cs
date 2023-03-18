﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3
{
    internal class Node
    {
        public string Info { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node() { }
        public Node(string info) { Info = info; }
        public Node(string info, Node left, Node right)
        {
            Info = info;
            Left = left;
            Right = right;
        }

    }
}
