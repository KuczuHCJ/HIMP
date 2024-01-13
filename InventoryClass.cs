using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMP
{
    
        class Invenotry
        {
            private static int NextID = 1;

            public int ID { get; private set; }
            public string Name { get; set; }
            public string Location { get; set; }
            public string Destription { get; set; }

            public Invenotry(string name, string location, string destription)
            {
                this.ID = NextID;
                this.Name = name;
                this.Location = location;
                this.Destription = destription;
                NextID++;
            }
        }
    
}
