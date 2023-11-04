using Antelcat.Avalonia.I18N.Demo;
using Avalonia;
using Avalonia.ReactiveUI;

BuildAvaloniaApp()
    .StartWithClassicDesktopLifetime(args);

static AppBuilder BuildAvaloniaApp()
    => AppBuilder.Configure<App>()
        .UsePlatformDetect()
        .LogToTrace()
        .UseReactiveUI();