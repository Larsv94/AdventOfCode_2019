using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3.BST
{
    class Tree<T>
    {
        Func<T, bool> comparePredicate { get; set; }
    }
}
