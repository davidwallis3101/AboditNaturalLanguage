using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPHelloWorldSampleObject
{
    public class Light : HouseBaseObject
    {
        public Light(string name, string uniqueID) : base(name, uniqueID)
        {
            this.Name = name;
            this.UniqueID = uniqueID;
        }

        public void Foo()
        {
            Console.WriteLine("Foo: Hello World");
        }
    }

}
