using Avalonia.Controls;

namespace CounterApp;

public partial class MainWindow : Window
{
    private int _counter = 0;  // Counter variable

    public MainWindow()
    {
        InitializeComponent();
    }

    private void IncrementCounter(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        _counter++;  // Increment the counter
        CounterText.Text = _counter.ToString();  // Update the TextBlock with the new counter value
    }
}