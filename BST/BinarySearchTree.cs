using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    //Creating a generic class and implementing IComparable interface, because we need to compare every time we insert a new node
    internal class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }

        //For left subtee
        public BinarySearchTree<T> LeftTree { get; set; }

        //For right subtree
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T nodeData)
        {
            NodeData = nodeData;
            LeftTree = null;
            RightTree = null;
        }

        //declaring static variables for counting total nodes in left and right subtree
        //reason behind static declaration is these variables will be assigned in the memory only once
        //This is very helpfull in recursion scenario since we have recursion in display method
        //if we don't declare these variables static their values will always change when new recursion starts
        //the value we will get in output will be the value before the first recursion starts
        public static int leftCount = 0, rightCount = 0;

        //Insertion logic
        public void Insert(T item)
        {
            T currentNodeValue = NodeData;

            //If currentNodeValue is greater than item
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                //if left subtree is null
                if (LeftTree == null)
                {
                    //put item in the left subtree
                    LeftTree = new BinarySearchTree<T>(item);
                }
                //if left subtree is not null
                else
                {
                    //recursive Insert method call on left subtree
                    LeftTree.Insert(item);
                }
            }

            //else currentNodeValue is less than item
            else
            {
                //if right subtree is null
                if (RightTree == null)
                {
                    //then put item in right subtree's root/parent node
                    RightTree = new BinarySearchTree<T>(item);
                }
                //if right subtree is not null
                else
                {
                    //recursive Insert method call on right subtree
                    RightTree.Insert(item);
                }
            }
        }

        //For displaying binary search tree
        public void Display()
        {
            //if left subtree is not null
            if (LeftTree != null)
            {
                //left subtree is not null here therefore increment the node count of left subtree i.e. leftCount++
                leftCount++;

                //then call display method recursively on left subtree
                LeftTree.Display();
            }

            //For printing the value present at the node
            Console.Write(NodeData.ToString() + " ");

            //if right subtree is not null
            if (RightTree != null)
            {
                //right subtree is not null here therefore increment the node count of right subtree i.e. rightCount++
                rightCount++;

                //call display method recursively on right subtree
                RightTree.Display();
            }
        }

        //For calculating the size of BST
        public void Size()
        {
            //prints left subtree count + right subtree count + 1 (for root node)
            Console.WriteLine("\nSize of the BST is : " + (1 + leftCount + rightCount));
        }
    }
}
