using Antelcat.Avalonia.I18N.Demo.ViewModels;
using Antelcat.Avalonia.I18N.Demo.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Antelcat.Avalonia.I18N.Demo
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            if (Design.IsDesignMode)
            {
                RequestedThemeVariant = ThemeVariant.Dark;
            }
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new ViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
