﻿using HIMP;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using Newtonsoft.Json;

namespace HIMP
{
    class Program 
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Home Inventory Management Program!\nRemember to save your changes before exiting the program:\nusing option number 6 Otherwise, your progress will be lost.");
            Console.WriteLine("~Kuczu");
            Thread.Sleep(4000);

            InventoryManagement programManagement = new InventoryManagement();



            programManagement.LoadInventoryFromJsonDataBase();
            


            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAM MENU");
                Console.WriteLine("What do you want to do with the program?");
                Console.WriteLine("\nAdd new inventory element - 1");
                Console.WriteLine("Show all inventory elements - 2");
                Console.WriteLine("Show one inventory element - 3");
                Console.WriteLine("Delete all inventory element - 4");
                Console.WriteLine("Delete inventory element - 5");
                Console.WriteLine("Edit Inventory element - 6");
                Console.WriteLine("Save work to data base - 7");
                Console.WriteLine("Close the program - 8");


                Console.WriteLine("\nCHOICE:");
                if (byte.TryParse(Console.ReadLine(), out byte choice) && choice >= 1 && choice <=8 )
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
                            programManagement.DeleteAllInventoryElements();
                            break;
                        case 5:
                            programManagement.DeleteInventoryElement();
                            break;
                        case 6:
                            programManagement.EditInventoryElement();
                            break;
                        case 7:
                            programManagement.SaveInventoryToJson();
                            break;
                        case 8:
                            programManagement.CloseTheProgram();
                            break;
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