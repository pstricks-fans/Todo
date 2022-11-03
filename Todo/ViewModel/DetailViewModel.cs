﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Todo.ViewModel;

[QueryProperty(nameof(Text), nameof(Text))]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string? text;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

}



