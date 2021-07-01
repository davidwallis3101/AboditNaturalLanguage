using AboditNLP;
using NLPHelloWorldSampleObject;

namespace NLPHelloWorldRules
{
    public class HouseObjectLexemeGenerator : ILexemeGenerator
    {
        private readonly IHouse house;
        public HouseObjectLexemeGenerator(IHouse house)
        {
            this.house = house;
        }

        public void CreateWords(ILexemeStore store)
        {
            foreach (var houseObject in house.Rooms)
            {
                System.Console.WriteLine($"storing {houseObject.Name}");
                store.Store(new HouseLexeme(houseObject.Name, houseObject));
            }
        }
    }

    public class HouseLexeme : LexNoun
    {
        public HouseLexeme(string text, HouseBaseObject houseBaseObject)
            : base(SynSet.Get(houseBaseObject.UniqueID), text)
        {
            this.Value = houseBaseObject;
        }

        public HouseBaseObject Value { get; private set; }
    }
}
