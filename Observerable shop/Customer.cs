using System.Collections.Specialized;
namespace CollectionsPractice;

public class Customer
{
    public static void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add when e.NewItems != null:

                foreach (var newItem in e.NewItems)
                {
                    if (newItem is Item item)
                    {
                        Console.WriteLine($" {item.Name} was added successfully.");
                    }
                }
                break;

            case NotifyCollectionChangedAction.Remove when e.OldItems != null:

                foreach (var oldItem in e.OldItems)
                {
                    if (oldItem is Item item)
                    {
                        Console.WriteLine($" {item.Id} {item.Name} was removed successfully");
                    }
                }
                break;

            default:
                Console.WriteLine("Collection does not changed");
                break;
        }
    }
}
