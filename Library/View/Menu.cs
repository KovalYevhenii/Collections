namespace ConDicLibrary.View
{
    internal class Menu
    {
        private MenuState _menuState;
        public enum MenuState
        {
            AddBook,
            UnreadedBook,
            Exit
        }

        public MenuState GetState() { return _menuState; }
        public void SetMenuState(MenuState newState)
        {
            _menuState = newState;
        }

        public void StartMenu()
        {
            Console.WriteLine("1) Add a book\n2) List of unreaded books\n3)Exit\n");
        }

        public string First()
        {
            Console.WriteLine("Enter book name: ");
            var bookName = Console.ReadLine();

            if (bookName != null) return bookName;

            throw new ArgumentNullException(nameof(bookName));
        }

        public void Second()
        {
            Console.WriteLine("List of unreaded books: ");
        }

        public void Close()
        {
            Console.WriteLine("Closing programm...");
        }

    }
}
