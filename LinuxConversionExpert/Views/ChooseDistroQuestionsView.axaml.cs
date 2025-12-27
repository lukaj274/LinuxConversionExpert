using System;
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

    public static ExperienceLevel ExperienceLevel;
    public static OtherSystemExperience MacExperience;
    public static OtherSystemExperience WindowsExperience;
    public static List<Usage> Usages = new List<Usage>();
    public static Age Age;

    private string _prompt;

    public string Prompt => _prompt;

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        // Check the answer to the first question
        if ((bool)Q1_1.IsChecked)
        {
            ExperienceLevel = ExperienceLevel.Beginner;
        }
        if ((bool)Q1_2.IsChecked)
        {
            ExperienceLevel = ExperienceLevel.Intermediate;
        }
        if ((bool)Q1_3.IsChecked)
        {
            ExperienceLevel = ExperienceLevel.Advanced;
        }
        
        // Check the answer to the second question
        if ((bool)Q2_1_1.IsChecked)
        {
            MacExperience = OtherSystemExperience.None;
        }
        if ((bool)Q2_1_2.IsChecked)
        {
            MacExperience = OtherSystemExperience.DidNotUnderstand;
        }
        if ((bool)Q2_1_3.IsChecked)
        {
            MacExperience = OtherSystemExperience.Some;
        }
        if ((bool)Q2_1_4.IsChecked)
        {
            MacExperience = OtherSystemExperience.PowerUser;
        }
        
        if ((bool)Q2_2_1.IsChecked)
        {
            WindowsExperience = OtherSystemExperience.None;
        }
        if ((bool)Q2_2_2.IsChecked)
        {
            WindowsExperience = OtherSystemExperience.DidNotUnderstand;
        }
        if ((bool)Q2_2_3.IsChecked)
        {
            WindowsExperience = OtherSystemExperience.Some;
        }
        if ((bool)Q2_2_4.IsChecked)
        {
            WindowsExperience = OtherSystemExperience.PowerUser;
        }
        
        // Check the answers to the third question
        
        if ((bool)Q3_1.IsChecked)
        {
            Usages.Add(Usage.Gaming);
        }
        if ((bool)Q3_2.IsChecked)
        {
            Usages.Add(Usage.WorkOrSchool);
        }
        if ((bool)Q3_3.IsChecked)
        {
            Usages.Add(Usage.Development);
        }
        if ((bool)Q3_4.IsChecked)
        {
            Usages.Add(Usage.Research);
        }
        
        // Check the answers to the fourth question
        if ((bool)Q4_1.IsChecked)
        {
            Age = Age.New;
        }
        if ((bool)Q4_2.IsChecked)
        {
            Age = Age.Few;
        }
        if ((bool)Q4_3.IsChecked)
        {
            Age = Age.Over5;
        }
        if ((bool)Q4_4.IsChecked)
        {
            Age = Age.Over10;
        }
        
        // Generate a prompt
        var generator = new PromptGenerator();
        _prompt = generator.GeneratePrompt(ExperienceLevel, MacExperience, WindowsExperience, Usages, Age);
    }
}