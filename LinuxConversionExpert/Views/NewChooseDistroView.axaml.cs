using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LinuxConversionExpert.Views;

public partial class NewChooseDistroView : UserControl
{
    private Type type;
    
    public NewChooseDistroView(UserControl caller)
    {
        type = caller.GetType();
        InitializeComponent();
    }

    private void Previous(object? sender, RoutedEventArgs e)
    {
        slides.Previous();
    }

    private void Next(object? sender, RoutedEventArgs e)
    {
        slides.Next();
    }
}