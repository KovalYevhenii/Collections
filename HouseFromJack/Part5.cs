
using System.Collections.Immutable;
namespace HouseFromJack
{
    internal class Part5
    {
        public ImmutableArray<string> Poem { get; set; }
        public Part5()
        {
            this.Poem = ImmutableArray<string>.Empty;
        }

        public void AddPart(ImmutableArray<string> text)
        {
            Poem = text.Add("Вот пес без хвоста,\r\n" +
                "Который за шиворот треплет кота,\r\n" +
                "Который пугает и ловит синицу,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\nКоторый построил Джек.\n");
        }
    }
}
