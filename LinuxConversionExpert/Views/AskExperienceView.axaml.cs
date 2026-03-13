using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LinuxConversionExpert.Views;

public partial class AskExperienceView : UserControl
{
    public AskExperienceView()
    {
        InitializeComponent();
    }

    private void Back_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new MainView();
    }

    private void Beginner_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new BeginnerDistroView();
    }

    private void Intermediate_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new IntermediateDistroView();
    }

    private void Advanced_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new AdvancedDistroView();
    }
}