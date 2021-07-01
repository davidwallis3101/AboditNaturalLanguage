using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPHelloWorldSampleObject
{
    public class House : IHouse, IEquatable<House>
    {
        private List<HouseBaseObject> rooms = new();

        public string Name { get; set; }
        public bool Equals(House other)
        {
            if (other == null)
                return false;

            if (this.Name == other.Name)
                return true;
            else
                return false;
        }


        public List<HouseBaseObject> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public override bool Equals(Object obj) => Equals(obj as IHouse);

        public override int GetHashCode() => this.Name.GetHashCode();
    }
}