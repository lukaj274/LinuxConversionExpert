using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;
using Avalonia.Interactivity;

namespace LinuxConversionExpert.Views;

public partial class ChooseDistroQuestionsView : UserControl
{
    public ChooseDistroQuestionsView()
    {
        InitializeComponent();
    }
    
    public static Dictionary<string, string> FormAnswers { get; private set; } = new Dictionary<string, string>();
}