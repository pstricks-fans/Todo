using Todo.ViewModel;

namespace Todo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services

            .AddSingleton<IConnectivity>(Connectivity.Current)

            .AddSingleton<MainPage>()
            .AddSingleton<MainViewModel>()

            .AddTransient<DetailPage>()
            .AddTransient<DetailViewModel>()
            
            ;

        return builder.Build();
    }
}
