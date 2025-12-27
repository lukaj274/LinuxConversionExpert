using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace LinuxConversionExpert.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void ChooseDistroButton_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Content = new ChooseDistroView();
    }
}