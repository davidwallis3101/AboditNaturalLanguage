using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPHelloWorldSampleObject
{
    public abstract class HouseBaseObject : IEquatable<HouseBaseObject>
    {
        public string Name { get; set; } = "Default Name";
        public string UniqueID { get; set; } = "UniqueId";

        public HouseBaseObject(string name, string uniqueId)
        {
            this.Name = name;
            this.UniqueID = uniqueId;
        }


        public bool Equals(HouseBaseObject other)
        {
            if (other == null)
                return false;

            if (this.Name == other.Name)
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj) => Equals(obj as HouseBaseObject);

        public override int GetHashCode() => this.Name.GetHashCode();
    }
}