using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System;

namespace ControleEstoque.AvaloniaUI.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isPaneOpen = true;

    [ObservableProperty]
    private ViewModelBase _currentPage = new OrdemPageViewModel();

    public ObservableCollection<ListItemTemplate> Items { get; } = new()
    {
        new ListItemTemplate(typeof(OrdemPageViewModel), "Ordens"),
        //new ListItemTemplate(typeof(ButtonPageViewModel)),
    };

    [ObservableProperty]
    private ListItemTemplate? _selectedListItem;

    partial void OnSelectedListItemChanged(ListItemTemplate? value)
    {
        if (value is null) return;
        var instance = Activator.CreateInstance(value.ModelType);
        if (instance is null) return;
        CurrentPage = (ViewModelBase)instance;
    }


    [RelayCommand]
    private void TriggerPane()
    {
        IsPaneOpen = !IsPaneOpen;
    }
}

public class ListItemTemplate
{

    public ListItemTemplate(Type type, string nome)
    {
        ModelType = type;
        Label =nome;
    }

    public string Label { get; }
    public Type ModelType { get; }
}
