using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Front.ViewModels;

namespace Front.Views.Main.Landing;

public partial class AdvantagesCardsView : UserControl
{
    public AdvantagesCardsView()
    {
        InitializeComponent();
        DataContext = new AdvantagesCardViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}