using System.Collections.ObjectModel;
namespace CollectionsPractice
{
    public class Shop
    {
        public ObservableCollection<Item> ItemsObservable { get; }
        public Shop()
        {
            ItemsObservable = new ObservableCollection<Item>();
        }
        
        public void Add(int itemId, string itemName)
        {
            Item item = new()
            {
                Id = itemId,
                Name = itemName
            };

            ItemsObservable.Add(item);
        }
        
        public void Remove(int itemId)
        {
            var itemToRemove = ItemsObservable.FirstOrDefault(x => x.Id == itemId);

            if (itemToRemove != null)
            {
                ItemsObservable.Remove(itemToRemove);
            }
            else
            {
                Console.WriteLine($"Item with ID {itemId} not found.");
            }
        }
    }
}
