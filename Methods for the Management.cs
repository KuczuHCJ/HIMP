using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


// Class created to support the management class in handling the program menu through methods

namespace HIMP
{
    abstract class MethodsForTheManagement
    {

        List<Inventory> homeInventoryList = new List<Inventory>();
        //Method called when no ID has been assigned within the program ye
        protected private void EmptyList()
        {
            Console.Clear();
            Console.WriteLine("your list is empty");
            Console.WriteLine("Return to the main menu");
            Thread.Sleep(2000);
        }

        //Method called when the user-entered ID could not be found
        protected private void IdNotExist()
        {
            Console.Clear();
            Console.WriteLine("The provided ID does not exist.");
            Console.WriteLine("Return to the main menu");
            Thread.Sleep(2000);
        }

        //Method used after displaying the values the user is looking for. They remain visible until the user finishes its operation by pressing a button.
        protected private void PressKey()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        
        //Method to Save Inventory List to TXT format
        internal void SaveInventoryToFile()
        {
            
            List<string> linesToWrite = new List<string>();

            foreach (var item in homeInventoryList)
            {
                string dataToWrite = $"{item.ID},{item.Name},{item.Location},{item.Description}";
                linesToWrite.Add(dataToWrite);
            }

            File.WriteAllLines("DataBase.txt", linesToWrite);
        }

    }
}
