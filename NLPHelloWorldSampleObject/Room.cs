using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPHelloWorldSampleObject
{
    public class Room : HouseBaseObject
    {
        //public string Name { get; set; } = "Default Name";
        //public string UniqueID { get; set; } = "UniqueId";

        public Room(string name, string uniqueID) : base(name, uniqueID)
        {
            this.Name = name;
            this.UniqueID = uniqueID;
        }
    }
}
