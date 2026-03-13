using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LinuxConversionExpert.Views;

public partial class IntermediateDistroView : UserControl
{
    public IntermediateDistroView()
    {
        InitializeComponent();
    }
    
    private void Back_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new AskExperienceView();
    }
}