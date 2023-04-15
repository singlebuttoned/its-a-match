using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Front.ViewModels;

namespace Front.Views.Main.Header;

public partial class HeaderView : UserControl
{
    public HeaderView()
    {
        InitializeComponent();
        DataContext = new HeaderViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}