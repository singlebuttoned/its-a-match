using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Front.ViewModels;

namespace Front.Views.Main.Landing;

public partial class BannerView : UserControl
{
    public BannerView()
    {
        InitializeComponent();
        DataContext = new BannerViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}