using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    { // member variables (HAS A)





        // constructor
        // member methods (CAN DO)
        public void CreateBST()
        {
            Node start = null;
            Tree binarySearchTree = new Tree();
            int size = 32;
            int[] newArray = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)  
            {
                newArray[i] = random.Next(10);

            }
            for (int i = 0; i < size; i++)
            {
                start = binarySearchTree.Insert(start, newArray[i]);
            }

            bool CheckTrue = binarySearchTree.Traverse(start, 7);
            Console.WriteLine(CheckTrue);
            Console.ReadLine();
                
        }
        
    }
}
