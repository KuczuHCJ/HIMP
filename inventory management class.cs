using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMP
{
    internal class inventory_management
    {
        public List<Inventory> homeInventoryList = [];

        public void Add_inventory()
        {
            Console.WriteLine("item name:");
            string name = Console.ReadLine();

            Console.WriteLine("item location");
            string location = Console.ReadLine();

            Console.WriteLine("item description");
            string description = Console.ReadLine();

            Inventory newItemToList = new Inventory(name, description, location);
            homeInventoryList.Add(newItemToList);
        }

        public void show_all_inventory()
        {
            foreach (var item in homeInventoryList)
            {
                Console.WriteLine($"ID:{item.ID} name: {item.Name}, description: {item.Description}, location: {item.Location}");
            }
        }

        public void DeleteInventoryElement()
        {
            Console.WriteLine("Enter the ID of the inventory item you want to delete:");

            if (int.TryParse(Console.ReadLine(), out int id))
            {

                if (id > 0 && id <= homeInventoryList.Count)
                {

                    Inventory itemToDelete = homeInventoryList.Find(item => item.ID == id);

                    if (itemToDelete != null)
                    {

                        homeInventoryList.Remove(itemToDelete);
                        Console.WriteLine($"Inventory item with ID {id} deleted successfully.");
                        foreach (var item in homeInventoryList.Where(item => item.ID > id))
                        {
                            item.ID--;
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Inventory item with ID {id} not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID provided. Please enter a valid ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid value provided. Please enter a valid integer ID.");
            }
        }


        public void ShowInventoryElement()
        {
            Console.WriteLine("Enter the ID of the inventory item you want to show:");
            if(int.TryParse(Console.ReadLine(),out int id))
            {
                if(id >0 && id < homeInventoryList.Count)
                {
                    Inventory itemToShow = homeInventoryList.Find(item => item.ID == id);
                    Console.WriteLine($"You selected the item with ID ={id}");
                    Console.WriteLine(itemToShow);
                }
                else
                {
                    Console.WriteLine($"Inventory item with ID {id} not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid value provided. Please enter a valid integer ID.");
            }
        }

        public void ClouseTheProgram()
        {
            Console.WriteLine("The program will be closed in five seconds.");
            Thread.Sleep(5000);
        }
    }





}



