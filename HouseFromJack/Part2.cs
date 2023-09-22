
using System.Collections.Immutable;
namespace HouseFromJack
{
    internal class Part2
    {
        public ImmutableArray<string> Poem { get; private set; }
        public Part2()
        {
            this.Poem = ImmutableArray<string>.Empty;
        }
        public void AddPart(ImmutableArray<string> text)
        {
            Poem = text.Add("А это пшеница,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\nКоторый построил Джек.\n");
        }
    }
}
