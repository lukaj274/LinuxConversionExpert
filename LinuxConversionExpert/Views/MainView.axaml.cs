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
        Content = new ChooseDistroView(this);
    }

    private void FindSoftwareButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new FindSoftwareView();
    }

    private void LearnButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new InstallDistroView();
    }
}