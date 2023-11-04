﻿using System.Globalization;
using System.Reflection;
using Antelcat.Avalonia.I18N.Demo.Models;
using Avalonia.Markup.Xaml.MarkupExtensions;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;

namespace Antelcat.Avalonia.I18N.Demo.ViewModels;

public partial class ViewModel : ObservableObject
{
    public ViewModel()
    {
        selectedKey = AvailableKeys.FirstOrDefault();
    }
    public CultureInfo Culture
    {
        get => culture;
        set
        {
            if (culture.EnglishName.Equals(value.EnglishName)) return;
            culture               = value;
            I18NExtension.Culture = value;
            OnPropertyChanged();
        }
    }

    private CultureInfo culture = new("zh");

    public IList<CultureInfo> AvailableCultures { get; } = new List<CultureInfo>
    {
        new("zh"),
        new("en")
    };

    public IList<string> AvailableKeys { get; } =
        typeof(LangKeys)
            .GetFields(BindingFlags.Static | BindingFlags.Public)
            .Select(x => x.Name)
            .ToList();
    
    [ObservableProperty] private string? selectedKey;
    
    [ObservableProperty] private string? inputText;
}
