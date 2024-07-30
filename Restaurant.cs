using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_management
{
    public class Restaurant
    {
        public List<MenuItem> menuItems = new List<MenuItem>();
        public List<MenuItem> orderItems = new List<MenuItem>();

        public void AddMenuItem()
        {
            Console.Write("Enter menu item name: ");
            string name = Console.ReadLine();
            Console.Write("Enter menu item price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            menuItems.Add(new MenuItem(name, price));
            Console.WriteLine("Menu item added successfully!");
        }

        public void RemoveMenuItem()
        {
            if (menuItems.Count == 0)
            {
                Console.WriteLine("No menu items to remove!");
                return;
            }

            Console.WriteLine("Select a menu item to remove:");
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i].Name} - {menuItems[i].Price}");
            }

            int choice = Convert.ToInt32(Console.ReadLine()) ;
            if (choice >= 0 && choice < menuItems.Count)
            {
                menuItems.RemoveAt(choice);
                Console.WriteLine("Menu item removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }

        public void DisplayMenu()
        {
            if (menuItems.Count == 0)
            {
                Console.WriteLine("No menu items to display!");
                return;
            }

            Console.WriteLine("Menu:");
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i].Name} - {menuItems[i].Price}");
            }
        }

        public void AddToOrder()
        {
            if (menuItems.Count == 0)
            {
                Console.WriteLine("No menu items to add to order!");
                return;
            }

            Console.WriteLine("Select  menu item and add to order:");
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i].Name} - {menuItems[i].Price}");
            }

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 0 && choice < menuItems.Count)
            {
                orderItems.Add(menuItems[choice]);
                Console.WriteLine("Menu item added to order successfully!");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }

        public void DisplayOrder()
        {
            if (orderItems.Count == 0)
            {
                Console.WriteLine("No items in order!");
                return;
            }

            decimal totalCost = 0;
            Console.WriteLine("Order:");
            for (int i = 0; i < orderItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {orderItems[i].Name} - {orderItems[i].Price}");
                totalCost += orderItems[i].Price;
            }

            Console.WriteLine($"Total Cost: {totalCost:f}");
        }
    }
}
