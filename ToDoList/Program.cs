using System;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Program
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to your ToDo list! Get to work!");
            Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
            string toAdd = Console.ReadLine().ToLower().Trim();
            if (toAdd == "add")
            {
                AddItem();
            }
            else if (toAdd == "view")
            {
                ViewItem();
            }
            else
            {
                Console.WriteLine("Please enter 'Add' / 'View', or press enter to exit app");
            }
        }
        public static void AddItem()
        {
            Console.WriteLine("Please enter the descrition for new item: ");
            string addResponse = Console.ReadLine();
            Item addDescription = new Item(addResponse);

            Console.WriteLine($"'{addDescription.Description}' has been added to your list. Would you like to add another item or view your list? [Add/View]");

            string newResponse = Console.ReadLine().ToLower().Trim();
            if (newResponse == "add")
            {
                AddItem();
            }
            else if (newResponse == "view")
            {
                ViewItem();
            }
            else
            {
                Console.WriteLine("Please enter 'Add'/'View' or press any key to exit application");
            }
        }

        public static void ViewItem()
        {
            List<Item> newList = Item.GetAll();
            foreach (Item li in newList)
            {
                Console.WriteLine(li.Description + "\n *-----------------------------*");
            }

            Console.WriteLine("Would you like to add an item to your list or view your current list? [Add/View]");
            string newResponse = Console.ReadLine().ToLower().Trim();
            if (newResponse == "add")
            {
                AddItem();
            }
            else if (newResponse == "view")
            {
                ViewItem();
            }
            else
            {
                Console.WriteLine("Please enter 'Add'/'View' or press any key to exit application");
                }
        }

    }

}
