
using System.Collections.Concurrent;

namespace ConDicLibrary.controller
{
    public class Library
    {
        private readonly ConcurrentDictionary<string, int> myBooks = new();

        public void AddBook(string bookName)
        {
            if (bookName != null)
            {
                if (myBooks.ContainsKey(bookName))
                {
                    Console.WriteLine("book with the same name already exist!");
                    return;
                }

                Thread thread = new(() => CountReadPercent(bookName));
                thread.Start();
            }
            else throw new ArgumentNullException(nameof(bookName));
        }

        private void CountReadPercent(string bookName)
        {
            for (int readPercent = 0; readPercent <= 100; readPercent++)
            {
                myBooks[bookName] = readPercent;

                if (readPercent == 100)
                {
                    RemoveBook(bookName);
                }

                Thread.Sleep(1000);
            }
        }

        public void ShowAllBooks()
        {
            foreach (var kvp in myBooks)
            {
                Console.WriteLine($"Book:[{kvp.Key}] read percent: {kvp.Value}%\n");
            }
        }
        private void RemoveBook(string bookName)
        {
            myBooks.TryRemove(bookName, out _);
        }
    }
}
