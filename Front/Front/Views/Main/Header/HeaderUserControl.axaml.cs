using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Front.Views.Main.Header;

public partial class HeaderUserControl : UserControl
{
    public HeaderUserControl()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}