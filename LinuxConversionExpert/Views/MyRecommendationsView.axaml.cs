using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LinuxConversionExpert.Views;

public partial class MyRecommendationsView : UserControl
{
    public MyRecommendationsView()
    {
        InitializeComponent();
        
        BeginnerDistros.Content = new BeginnerDistroView();
        IntermediateDistros.Content = new IntermediateDistroView();
        AdvancedDistros.Content = new AdvancedDistroView();
        
        Software.Content = new FindSoftwareView();
    }

    private void Back_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new MainView();
    }
}