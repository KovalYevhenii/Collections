
using System.Collections.Immutable;

namespace HouseFromJack
{
    internal class Part6
    {
        public ImmutableArray<string> Poem { get; set; }
        public Part6()
        {
            this.Poem = ImmutableArray<string>.Empty;
        }

        public void AddPart(ImmutableArray<string> text)
        {
            Poem = text.Add("А это корова безрогая,\r\n" +
                "Лягнувшая старого пса без хвоста,\r\nКоторый за шиворот треплет кота,\r\n" +
                "Который пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.\n");
        }
    }
}
