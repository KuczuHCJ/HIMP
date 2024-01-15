using HIMP;
using System;
using System.Collections.Generic;
using System.Threading; // Dodaj ten using do korzystania z Thread.Sleep

namespace HIMP
{
    class Program
    {
        static void Main()
        {
            InventoryManagement programManagement = new InventoryManagement();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAM MENU");
                Console.WriteLine("What do you want to do with the program?");
                Console.WriteLine("\nAdd new inventory element - 1");
                Console.WriteLine("Show all inventory elements - 2");
                Console.WriteLine("Show one inventory element - 3");
                Console.WriteLine("Delete inventory element - 4");
                Console.WriteLine("Edit Inventory element - 5");
                Console.WriteLine("Close the program - 6");

                Console.WriteLine("\nCHOICE:");
                if (byte.TryParse(Console.ReadLine(), out byte choice) && choice >= 1 && choice <= 6)
                {
                    switch (choice)
                    {
                        case 1:
                            programManagement.AddInventoryElement();
                            break;
                        case 2:
                            programManagement.ShowAllInventory();
                            break;
                        case 3:
                            programManagement.ShowInventoryElement();
                            break;
                        case 4:
                            programManagement.DeleteInventoryElement();
                            break;
                        case 5:
                            programManagement.EditInventoryElement();
                            break;
                        case 6:
                            programManagement.CloseTheProgram();
                            return;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("An incorrect value has been entered");
                    Thread.Sleep(3000);
                    continue;
                }
            }
        }
    }
}