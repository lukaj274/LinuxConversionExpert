using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LinuxConversionExpert.Views;

public partial class InstallOtherDistroView : UserControl
{
    public InstallOtherDistroView()
    {
        InitializeComponent();
    }

    public InstallOtherDistroView(string os)
    {
        InitializeComponent();

        if (os == "mac")
        {
            Tabs.SelectedIndex = 1;
        }
    }

    private void Back_OnClick(object? sender, RoutedEventArgs e)
    {
        // Reset the padding and switch to the InstallDistroView page
        var installView = new InstallDistroView();
        Padding = installView.Padding;
        Content = installView;
    }
}