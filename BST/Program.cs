namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to Binary Search Tree program");
            int choice;
            while (true)
            {
                Console.WriteLine("\n1. Create Binary Search Tree byadding 56 and then adding 30 & 70");
                Console.WriteLine("2. Create binary tree as show in the figure also show size (restart before chosing, contains static variables)");
                Console.WriteLine("3. Search 63 in the Binary Search Tree");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BinarySearchTree<int> binary1 = new BinarySearchTree<int>(56);
                        binary1.Insert(30);
                        binary1.Insert(70);
                        Console.WriteLine("Binary Search Tree (in inorder traversal) is :");
                        binary1.Display();
                        break;
                    case 2:
                        BinarySearchTree<int> binary2 = new BinarySearchTree<int>(56);
                        binary2.Insert(30);
                        binary2.Insert(70);
                        binary2.Insert(22);
                        binary2.Insert(40);
                        binary2.Insert(60);
                        binary2.Insert(95);
                        binary2.Insert(11);
                        binary2.Insert(65);
                        binary2.Insert(3);
                        binary2.Insert(16);
                        binary2.Insert(63);
                        binary2.Insert(67);
                        Console.WriteLine("Binary Search Tree (in inorder traversal) is :");
                        binary2.Display();
                        binary2.Size();
                        break;
                    case 3:
                        BinarySearchTree<int> binary3 = new BinarySearchTree<int>(56);
                        binary3.Insert(30);
                        binary3.Insert(70);
                        binary3.Insert(22);
                        binary3.Insert(40);
                        binary3.Insert(60);
                        binary3.Insert(95);
                        binary3.Insert(11);
                        binary3.Insert(65);
                        binary3.Insert(3);
                        binary3.Insert(16);
                        binary3.Insert(63);
                        binary3.Insert(67);
                        Console.WriteLine("Binary Search Tree (in inorder traversal) is :");
                        binary3.Display();
                        binary3.IsPresent(63, binary3);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Please choose correct option");
                        break;
                }

            }
        }
    }
}