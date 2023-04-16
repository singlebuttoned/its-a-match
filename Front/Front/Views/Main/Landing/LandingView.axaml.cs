using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Front.ViewModels;

namespace Front.Views.Main.Landing;

public partial class LandingView : UserControl
{
    public LandingView()
    {
        InitializeComponent();
        DataContext = new LandingViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}