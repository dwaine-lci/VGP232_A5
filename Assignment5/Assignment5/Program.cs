using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");

            // TODO: Create an inventory
            // TODO: Add 2 items to the inventory
            // Verify the number of items in the inventory.
            Inventory inventory = new Inventory(15);
            inventory.AddItem(new Item("Axe", 12, ItemGroup.Equipment));
            inventory.AddItem(new Item("Sword", 12, ItemGroup.Equipment));

        }
    }
}
