using Avalonia.Controls;
using AvaloniaApplicationReact.ViewModels;

namespace AvaloniaApplicationReact.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        DataContext = new MainViewModel(); // Устанавливаем DataContext
    }
}
