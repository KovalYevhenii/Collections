
using System.Collections.Concurrent;
namespace ConDicLibrary.controller;
public class Library
{
    private readonly int defaultReadProgress = 0;
    private readonly ConcurrentDictionary<string, int> myBooks = new();
    private readonly Thread trackingReadProgressThread;
    public Library()
    {
        trackingReadProgressThread = new(CountReadPercent);
        trackingReadProgressThread.Start();
    }
    public void AddBook(string bookName)
    {
        if (bookName != null)
        {
            if (myBooks.ContainsKey(bookName))
            {
                Console.WriteLine("book with the same name already exist!");
                return;
            }
            else
            {
                myBooks.TryAdd(bookName, defaultReadProgress);
            }
        }
        else throw new ArgumentNullException(nameof(bookName));
    }
    private void CountReadPercent()
    {
        int maxReadPercent = 100;
        while (true)
        {
            foreach (var bookName in myBooks.Keys)
            {
                if (myBooks[bookName] < maxReadPercent)
                {
                    myBooks[bookName] += 1;
                }
                else
                {
                    RemoveBook(bookName);
                }
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
