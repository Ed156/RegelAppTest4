using Microsoft.Extensions.Logging;

namespace RegelApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureEssentials(essentials =>
                {
                    essentials.UseVersionTracking();
                }) ;

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif


            return builder.Build();
        }

    }
}