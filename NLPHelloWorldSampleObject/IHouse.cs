using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPHelloWorldSampleObject
{
    public interface IHouse 
    {
        string Name { get; set; }

        List<HouseBaseObject> Rooms { get; set; }

        bool Equals(House other);
        bool Equals(object obj);
        int GetHashCode();
    }

}
