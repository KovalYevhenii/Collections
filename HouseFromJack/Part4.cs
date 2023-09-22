using System.Collections.Immutable;
namespace HouseFromJack
{
    internal class Part4
    {
        public ImmutableArray<string> Poem { get; private set; }
        public Part4()
        {
            this.Poem = ImmutableArray<string>.Empty;
        }

        public void AddPart(ImmutableArray<string> text)
        {
            Poem = text.Add("Вот кот,\r\n" +
                "Который пугает и ловит синицу,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\nВ доме,\r\n" +
                "Который построил Джек.\n");
        }
    }
}
