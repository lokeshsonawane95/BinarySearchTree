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