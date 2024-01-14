using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMP
{
    internal class InventoryManagement
    {
        public List<Inventory> homeInventoryList = [];

        public void AddInventoryElement()
        {
            Console.WriteLine("item name:");
            string name = Console.ReadLine();

            Console.WriteLine("item location");
            string location = Console.ReadLine();

            Console.WriteLine("item description");
            string description = Console.ReadLine();

            Inventory newItemToList = new(name, description, location);
            homeInventoryList.Add(newItemToList);
        }

        public void ShowAllInventory()
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
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                if (id > 0 && id < homeInventoryList.Count)
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

        public void EditInventoryElement()
        {
            int yesOrNo = 0;
            do { 
            Console.WriteLine("Enter the ID of the inventory item you want to edit:");
                if (int.TryParse(Console.ReadLine(), out int id))
                {

                    if (id > 0 && id <= homeInventoryList.Count)
                    {
                        Inventory itemToEdit = homeInventoryList.Find(item => item.ID == id);
                        Console.WriteLine($"You selected the item with ID ={id}");
                        Console.WriteLine($"Name: {itemToEdit.Name} \nDescription: {itemToEdit.Description} \nLocation: {itemToEdit.Location}");
                        Console.WriteLine($"What do you want to edit?");
                        Console.WriteLine("1 - Name, 2 - Description, 3-Location");

                        if (int.TryParse(Console.ReadLine(), out int edit) && 1 <= edit || edit <= 3)
                        {
                            switch (edit)
                            {
                                case 1:
                                    Console.WriteLine("New item name:");
                                    itemToEdit.Name = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("New item description:");
                                    itemToEdit.Description = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("new item location:");
                                    itemToEdit.Location = Console.ReadLine();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("The provided number is outside the range.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Inventory item with ID {id} not found.");
                    }

                }
                while (true)
                {
                    Console.WriteLine("Do you want to edit another element?");
                    Console.WriteLine("1 - yes \n2 - no");
                    if (int.TryParse(Console.ReadLine(), out yesOrNo) && yesOrNo == 1 || yesOrNo == 2)
                    {
                        Console.WriteLine($"Selected {yesOrNo}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("An incorrect value has been selected");
                        continue;
                    }
                }

            } while (yesOrNo == 1);

            
        }

        public void CloseTheProgram()
        {
            Console.WriteLine("The program will be closed in five seconds.");
            Thread.Sleep(5000);
        }



    }
}




