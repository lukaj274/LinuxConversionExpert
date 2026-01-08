using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LinuxConversionExpert.Views;

public partial class ChooseDistroView : UserControl
{
    private Type type;
    
    public ChooseDistroView(UserControl caller)
    {
        type = caller.GetType();
        InitializeComponent();
    }
    
    private void FindDistro_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = new ChooseDistroQuestionsView();
    }

    private void Back_OnClick(object? sender, RoutedEventArgs e)
    {
        Content = Activator.CreateInstance(type);
    }
}