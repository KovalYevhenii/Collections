using System.Linq;

namespace HouseFromJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1 part1 = new();
            Part2 part2 = new();
            Part3 part3 = new();
            Part4 part4 = new();
            Part5 part5 = new();
            Part6 part6 = new();
            Part7 part7 = new();
            Part8 part8 = new();
            Part9 part9 = new();

            part1.AddPart();
            part2.AddPart(part1.Poem);
            part3.AddPart(part2.Poem);
            part4.AddPart(part3.Poem);
            part5.AddPart(part4.Poem);
            part6.AddPart(part5.Poem);
            part7.AddPart(part6.Poem);
            part8.AddPart(part7.Poem);
            part9.AddPart(part8.Poem);

            Console.WriteLine(string.Join(' ', part1.Poem));
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', part2.Poem));
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', part3.Poem));
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', part4.Poem));
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', part5.Poem));
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', part6.Poem));
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', part7.Poem));
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', part8.Poem));
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', part9.Poem));
        }
    }
}