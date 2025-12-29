using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LinuxConversionExpert.Views;

public partial class FindSoftwareView : UserControl
{
    public FindSoftwareView()
    {
        InitializeComponent();
    }

    private void Back_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Content = new MainView();
    }
}