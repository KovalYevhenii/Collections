using System.Collections.Specialized;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new();

            while (true)
            {
                Console.WriteLine(
                    "1) press 'A' to add Item to shop\n" +
                    "2) Press 'D' to delete Item from shop\n" +
                    "3) Press 'X' to close programm\n");

                var userInput = Console.ReadLine() ?? throw new Exception();

                switch (userInput.ToUpper())
                {

                    case "A":
                        Console.WriteLine("Enter the Item ID");
                        var itemIdInput = Console.ReadLine();

                        if (int.TryParse(itemIdInput, out int itemId))
                        {
                            var itemName = "Item from " + DateTime.Now.ToString();

                            shop.Add(itemId, itemName);
                        }
                        else
                        {
                            Console.WriteLine("Enter valid number");
                        }
                        break;

                    case "D":
                        Console.WriteLine("Enter the Item ID to delete:");
                        var itemIdToDeleteInput = Console.ReadLine();

                        if (int.TryParse(itemIdToDeleteInput, out int itemIdToDelete))
                        {
                            shop.Remove(itemIdToDelete);
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid number.");
                        }
                        break;

                    case "X":
                        Environment.Exit(0);
                        break;
                } 
            }
        }
    }
}