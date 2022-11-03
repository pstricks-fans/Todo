using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Todo.ViewModel;


public partial class MainViewModel : ObservableObject
{
    public MainViewModel(IConnectivity connectivity)
    {
        items = new ObservableCollection<string>();
        this.connectivity = connectivity;
    }

    private readonly IConnectivity connectivity;

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text = default!;

    [RelayCommand]
    async Task Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        if (connectivity.NetworkAccess != NetworkAccess.Internet)
        {
            await Shell.Current.DisplayAlert("Error", "No Internet!", "Ok");
            return;
        }
        Items.Add(Text);
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
            Items.Remove(s);
    }

    [RelayCommand]
    async Task Tap(string s)
    {
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
    }
}
