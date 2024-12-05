using AvaloniaApplicationReact.Models;
using System.Collections.ObjectModel;

namespace AvaloniaApplicationReact.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public ObservableCollection<ItemModel> Items { get; }

    public MainViewModel()
    {
        Items = new ObservableCollection<ItemModel>
            {
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" },
                new ItemModel { Name = "Item 1" },
                new ItemModel { Name = "Item 2" },
                new ItemModel { Name = "Item 3" }
            };
    }
}
