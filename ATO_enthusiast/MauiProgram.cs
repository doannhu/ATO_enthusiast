using ATO_enthusiast.Plugins.DataStore.InMemory;
using ATO_enthusiast.UseCases.PersonalDetailsInterfaces;
using ATO_enthusiast.UseCases.PersonalDetailsUseCase;
using ATO_enthusiast.UseCases.PluginInterfaces;
using ATO_enthusiast.ViewModels;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using ATO_enthusiast.Views;

namespace ATO_enthusiast
{
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
            builder.UseMauiApp<App>().UseMauiCommunityToolkit();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            // Dependency injection
            builder.Services.AddSingleton<IPersonalDetailsRepository, PersonalDetailsInMemoryRepository>();
            builder.Services.AddSingleton<IViewPersonalDetailsUseCase, ViewPersonalDetailsUseCase>();
            builder.Services.AddTransient<IEditPersonalDetailsUseCase, EditPersonalDetailsUseCase>();

            builder.Services.AddSingleton<PersonalDetailsViewModel>();

            builder.Services.AddSingleton<EditPersonalDetailsPage>();
            builder.Services.AddSingleton<PersonalDetailsPage>();

            return builder.Build();
        }
    }
}
