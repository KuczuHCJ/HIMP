using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMP
{
    internal class InventoryManagement
    {


        public List<Inventory> homeInventoryList = new List<Inventory>();

        public void AddInventoryElement()   
        {
            Console.Clear();
            byte choice = 1;
            do
            {
                Console.WriteLine("Adding a new element:");

                Console.WriteLine("\nitem name:");
                string name = Console.ReadLine();

                Console.WriteLine("\nitem location:");
                string location = Console.ReadLine();

                Console.WriteLine("\nitem description:");
                string description = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"you add new element:\nname = {name} \nlocation = {location} \ndescription = {description}");
                
                Thread.Sleep(2000);
                Console.Clear();

                Inventory newItemToList = new(name, description, location);
                homeInventoryList.Add(newItemToList);

                while (true)
                {
                    Console.WriteLine("Do you want add next elemnt to list? \n1 - yes \n2 - no");
                    if (byte.TryParse(Console.ReadLine(), out choice) && choice == 1 || choice == 2)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong number provided try again");
                        Thread.Sleep(3000);
                        Console.Clear();
                        continue;
                    }
                }
              Thread.Sleep(1000);

            } while (choice == 1);
        }

        public void ShowAllInventory() 
        {
            Console.Clear();
            if (homeInventoryList.Count > 0)
            {
                foreach (var item in homeInventoryList)
                {
                    Console.WriteLine(" |________________________________________________________________________________________|");
                    Console.WriteLine($"|ID:{item.ID}|name: {item.Name}|description: {item.Description}|location: {item.Location}|");
                    Console.WriteLine(" |________________________________________________________________________________________|");
                }
            }
            else
            {
                Console.WriteLine("Your list is empty\n");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
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
            byte yesOrNo = 0;
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

                        if (byte.TryParse(Console.ReadLine(), out byte edit) && 1 <= edit || edit <= 3)
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
                    if (byte.TryParse(Console.ReadLine(), out yesOrNo) && yesOrNo == 1 || yesOrNo == 2)
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




