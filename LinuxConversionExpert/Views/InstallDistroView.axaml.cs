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
        // Reset the padding and switch to the ChooseDistroView page
        var distroView = new ChooseDistroView(this);
        Padding = distroView.Padding;
        Content = distroView;
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
        // Resset the padding and switch to the InstallOtherDistroView page
        var otherDistroView = new InstallOtherDistroView();
        Padding = otherDistroView.Padding;
        Content = otherDistroView;
    }

    private void Back_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new MainView();
    }
}