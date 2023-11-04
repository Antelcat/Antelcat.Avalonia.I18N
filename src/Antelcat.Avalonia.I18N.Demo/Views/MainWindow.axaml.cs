using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.MarkupExtensions;

namespace Antelcat.Avalonia.I18N.Demo.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var culture = "zh";
            var timer = new System.Timers.Timer
            {
                Interval  = 1000,
                AutoReset = true
            };
            timer.Elapsed += (_, __) =>
            {
                culture               = culture == "zh" ? "en" : "zh";
                I18NExtension.Culture = new CultureInfo(culture);
            };
            timer.Start();
        }
    }
}
