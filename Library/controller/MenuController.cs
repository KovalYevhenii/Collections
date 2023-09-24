using ConDicLibrary.View;
using static ConDicLibrary.View.Menu;

namespace ConDicLibrary.controller
{
    internal class MenuController
    {
        private readonly Menu _menu;
        private readonly Library _library;
        public MenuController(Library library)
        {
            _library = library;
            Menu menu = new();
            _menu = menu;
        }
        public void Start()
        {
            while (true)
            {
                _menu.StartMenu();
                var input = Console.ReadLine();

                if (int.TryParse(input, out int res))
                {
                    switch (res)
                    {
                        case 1:
                            {
                                _menu.SetMenuState(MenuState.AddBook);
                                var bookName = _menu.First();
                                _library.AddBook(bookName);
                                break;
                            }
                        case 2:
                            {
                                _menu.SetMenuState(MenuState.UnreadedBook);
                                _menu.Second();
                                _library.ShowAllBooks();
                                break;
                            }
                        case 3:
                            {
                                _menu.SetMenuState(MenuState.Exit);
                                _menu.Close();
                                Environment.Exit(0);
                                break;
                            }
                        default:
                            _menu.StartMenu();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
        }
    }
}
