using AccountsManager.Components;

using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace AccountsManager.Windows;

public partial class AuthWindow : Window
{
    public AuthWindow()
    {
        InitializeComponent();
    }

    private void Button_Auth_OnClick(object? sender, RoutedEventArgs e)
    {
        var mainWindow = new Windows.MainWindow();
        mainWindow.Show();
        
        this.Close();
    }

    private void Button_Cancel_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void Input_OnTextInput(object? sender, RoutedEventArgs routedEventArgs)
    {
        var text = (sender as InputComponent)?.Value;
        Button_Login.IsEnabled = !string.IsNullOrWhiteSpace(text);
    }
}