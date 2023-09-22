using System.Collections.Immutable;
namespace HouseFromJack
{
    internal class Part1
    {
        public ImmutableArray<string> Poem { get; private set; }

        public Part1()
        {
            Poem = ImmutableArray<string>.Empty;
        }

        public void AddPart()
        {
            Poem = Poem.Add("Вот дом,\r\nКоторый построил Джек.\n");
        }
    }
}
