using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    { // member variables (HAS A)
      // constructor
      // member methods (CAN DO)
        public Node Insert(Node start, int value)
        {

            if (start == null)
            {
                start = new Node();
                start.value = value;
            }
            else if (value < start.value)
            {
                start.leftNode = Insert(start.leftNode, value);
            }

            else
            {
                start.rightNode = Insert(start.rightNode, value);
            }
            return start;
        }
        public bool Traverse(Node start, int value)
        {
            if (start == null)
            {
                return false;
            }
            else if (start.value == value)
            {
                return true;
            }
            else if (start.value < value)
            {
                return Traverse(start.rightNode, value);
            }
            else if (start.value > value)
            {
                return Traverse(start.leftNode, value);
            }
            else
            {

                return false;
            }
        }
    }
}

