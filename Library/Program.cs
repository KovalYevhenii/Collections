using ConDicLibrary.controller;
namespace ConDicLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            MenuController controller = new(library);
            controller.Start();            
        }
    }
}