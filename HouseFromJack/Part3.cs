using System.Collections.Immutable;
namespace HouseFromJack
{
    internal class Part3
    {
        public ImmutableArray<string> Poem { get; private set; }
        public Part3()
        {
            this.Poem = ImmutableArray<string>.Empty;
        }

        public void AddPart(ImmutableArray<string> text)
        {
            Poem = text.Add("А это веселая птица-синица,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\nКоторый построил Джек.\n");
        }
    }
}
