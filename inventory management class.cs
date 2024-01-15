using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMP
{
    internal sealed class InventoryManagement : MethodsForTheManagement 
    {
        //Class created to manage the program's logic

        public List<Inventory> homeInventoryList = new List<Inventory>();


        //Method allowing the user to add an element to the list
        internal void AddInventoryElement()
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

                PressKey();

                Inventory newItemToList = new(name, description, location);
                homeInventoryList.Add(newItemToList);

                do
                {
                    Console.WriteLine("Do you want add next elemnt to list? \n1 - yes \n2 - no");
                    if (byte.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2))
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
                } while (choice != 1);
                

            } while (choice == 1);
        }

        //Method allowing the user to familiarize themselves with the entire list in the program
        internal void ShowAllInventory()
        {
            Console.Clear();
            if (homeInventoryList.Count > 0)
            {
                foreach (var item in homeInventoryList)
                {
                    
                    Console.WriteLine($"  ID:{item.ID}|name: {item.Name}|description: {item.Description}|location: {item.Location}");
                    Console.WriteLine("\n");
                    
                }
                PressKey();
            }
            else
            {
                EmptyList();
            }
            
        }

        //Method for deleting elements.
        internal void DeleteInventoryElement()
        {


            if (homeInventoryList.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Enter the ID of the inventory item you want to delete:");
                if (int.TryParse(Console.ReadLine(), out int id))
                {

                    Inventory itemToDelete = homeInventoryList.Find(item => item.ID == id);
                    if (itemToDelete != null)
                    {
                        homeInventoryList.Remove(itemToDelete);
                        Console.Clear();
                        Console.WriteLine($"Inventory item with ID {id} deleted successfully.");
                        PressKey();
                        foreach (var item in homeInventoryList.Where(item => item.ID > id))
                        {
                            item.ID--;

                        }
                        Inventory.NextID--;
                    }
                    else
                    {
                        IdNotExist();
                    }
                }
                else
                {
                    IdNotExist();
                }
            }
            else
            {
                EmptyList();
            }

        }

        //Method allowing to display a single element
        internal void ShowInventoryElement()
        {
            Console.Clear();
            if (homeInventoryList.Count > 0)
            {
                Console.WriteLine("Enter the ID of the inventory item you want to show:");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    if (id > 0 && id < homeInventoryList.Count)
                    {
                        Inventory itemToShow = homeInventoryList.Find(item => item.ID == id);
                        Console.WriteLine($"You selected the item with ID ={id}");
                        Console.WriteLine($"ID: {itemToShow.ID} | Name: {itemToShow.Name} | Description: {itemToShow.Description} | Location: {itemToShow.Location}");
                        PressKey();

                    }
                    else
                    {
                        IdNotExist();
                    }
                }
                else
                {
                    IdNotExist();

                }
            }
            else
            {
                EmptyList();
            }
        }

        //Method allowing for the editing of an element
        internal void EditInventoryElement()
        {
            byte yesOrNo = 0;
            if (homeInventoryList.Count > 0)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter the ID of the inventory item you want to edit:");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {

                        if (id > 0 && id <= homeInventoryList.Count)
                        {
                            Inventory itemToEdit = homeInventoryList.Find(item => item.ID == id);
                            Console.Clear();
                            Console.WriteLine($"You selected the item with ID ={id}");
                            Console.WriteLine($"Name: {itemToEdit.Name} \nDescription: {itemToEdit.Description} \nLocation: {itemToEdit.Location}");
                            Console.WriteLine($"What do you want to edit?");
                            Console.WriteLine("1 - Name  2 - Description  3-Location");

                            if (byte.TryParse(Console.ReadLine(), out byte edit) && 1 <= edit || edit <= 3)
                            {
                                switch (edit)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("New item name:");
                                        itemToEdit.Name = Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("New item description:");
                                        itemToEdit.Description = Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("new item location:");
                                        itemToEdit.Location = Console.ReadLine();
                                        break;
                                }
                                Console.Clear();
                                Console.WriteLine($"Object data after the edit has been completed:\nName:{itemToEdit.Name}\nDescription:{itemToEdit.Description}\nLocation:{itemToEdit.Location}");
                                PressKey();
                            }
                            else
                            {
                                IdNotExist();
                            }

                        }
                        else
                        {
                            IdNotExist();
                        }

                    }
                    while (true)
                    {
                        Console.Clear();
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
            else
            {
                EmptyList();
            }

        }

        //Method ending the program execution.
        internal void CloseTheProgram()
        {
            Console.WriteLine("The program will be closed in five seconds.");
            Thread.Sleep(5000);
        }





        
    }
}




