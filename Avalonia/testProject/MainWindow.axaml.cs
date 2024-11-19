using Avalonia.Controls;
using Avalonia.Interactivity;


namespace testProject;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnButtonClick(object? sender, RoutedEventArgs e)
    {
        System.Console.WriteLine("Button was clicked!");
    }
}