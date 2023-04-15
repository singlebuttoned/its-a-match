using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Front.Views.Main.Landing;

public partial class BannerView : UserControl
{
    public BannerView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}