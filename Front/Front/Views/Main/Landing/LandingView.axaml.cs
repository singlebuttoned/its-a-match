using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Front.Views.Main.Landing;

public partial class LandingView : UserControl
{
    public LandingView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}