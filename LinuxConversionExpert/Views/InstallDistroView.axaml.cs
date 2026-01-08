using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LinuxConversionExpert.Views;

public partial class InstallDistroView : UserControl
{
    public InstallDistroView()
    {
        InitializeComponent();
    }

    private void UnsureDistro_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new ChooseDistroView();
    }

    private void ZorinOS_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void Kubuntu_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void Mint_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void Ubuntu_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void DifferentDistro_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void Back_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new MainView();
    }
}