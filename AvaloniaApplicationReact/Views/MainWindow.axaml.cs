using Avalonia.Controls;
using AvaloniaApplicationReact.ViewModels;

namespace AvaloniaApplicationReact.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
