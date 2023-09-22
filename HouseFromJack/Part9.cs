using System.Collections.Immutable;
namespace HouseFromJack
{
    internal class Part9
    {
        public ImmutableArray<string> Poem { get; set; }
        public Part9()
        {
            this.Poem = ImmutableArray<string>.Empty;
        }

        public void AddPart(ImmutableArray<string> text)
        {
            Poem = text.Add("Вот два петуха,\r\n" +
                "Которые будят того пастуха,\r\n" +
                "Который бранится с коровницей строгою,\r\n" +
                "Которая доит корову безрогую,\r\n" +
                "Лягнувшую старого пса без хвоста,\r\n" +
                "Который за шиворот треплет кота,\r\n" +
                "Который пугает и ловит синицу,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\nКоторый построил Джек.");

        }
    }
}
