using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPHelloWorldSampleObject
{
    public static class init
    {
        public static IHouse createExample()
        {
            var house = new House();
            //house.Rooms.Add(new HouseBaseObject("hba1", "1"));
            //house.Rooms.Add(new HouseBaseObject("hba2", "2"));
            house.Rooms.Add(new Room("Room", "1"));
            house.Rooms.Add(new Room("AnotherRoom", "2"));
            //var house = new HouseBaseObject();
            return house;
        }
    }

}
