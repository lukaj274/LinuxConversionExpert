using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LinuxConversionExpert.Views;

public partial class ChooseDistroView : UserControl
{
    public ChooseDistroView()
    {
        InitializeComponent();
    }
    
    private void FindDistro_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Content = new ChooseDistroQuestionsView();
    }

    private void Back_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Content = new MainView();
    }
}