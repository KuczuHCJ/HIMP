using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMP
{
    
        internal class Inventory
    {
            private static int NextID = 1;

            public int ID { get; internal set; }
            public string Name { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }


        public Inventory(string name, string location, string description)
        {
            this.ID = NextID;
            this.Name = name;
            this.Location = location;
            this.Description = description; 
            NextID++;
        }
    }
    
}
