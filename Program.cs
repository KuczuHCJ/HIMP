using HIMP;
using System;
using System.Collections.Generic;

namespace HIMP
{
    class Program
    {
        

        static void Main()
        {
            InventoryManagement ProgramManagment = new InventoryManagement();

            ProgramManagment.AddInventoryElement();
            ProgramManagment.AddInventoryElement();
            ProgramManagment.AddInventoryElement();

            ProgramManagment.ShowAllInventory();

            ProgramManagment.DeleteInventoryElement();
            ProgramManagment.ShowAllInventory();

            ProgramManagment.AddInventoryElement();

            ProgramManagment.ShowInventoryElement();
            ProgramManagment.EditInventoryElement();
            ProgramManagment.ShowInventoryElement();

            ProgramManagment.ShowAllInventory();

            ProgramManagment.CloseTheProgram();


        }
    }

   
    

}