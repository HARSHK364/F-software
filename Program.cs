// See https://aka.ms/new-console-template for more information
using Resturant_management;

class Program
{
    static void Main(string[] args)
    {
        Restaurant restaurant = new Restaurant();

        while (true)
        {
            Console.WriteLine("Restaurant Management System");
            Console.WriteLine("1. Add Menu Item");
            Console.WriteLine("2. Remove Menu Item");
            Console.WriteLine("3. Display Menu");
            Console.WriteLine("4. Add to Order");
            Console.WriteLine("5. Display Order");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    restaurant.AddMenuItem();
                    break;
                case 2:
                    restaurant.RemoveMenuItem();
                    break;
                case 3:
                    restaurant.DisplayMenu();
                    break;
                case 4:
                    restaurant.AddToOrder();
                    break;
                case 5:
                    restaurant.DisplayOrder();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine();
        }
    }
}