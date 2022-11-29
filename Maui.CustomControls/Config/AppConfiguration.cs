using Maui.CustomControls.Controls.Button;
using Maui.CustomControls.ViewModels;
using Maui.CustomControls.Views;

namespace Maui.CustomControls.Config;

public static class AppConfiguration
{
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder app)
    {
        app.Services.AddTransient<MainPageViewModel>();

        return app;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder app)
    {
        app.Services.AddTransient<MainPageView>();
        app.Services.AddTransient<MainPageViewXaml>();

        return app;
    }

    public static MauiAppBuilder RegisterServices(this MauiAppBuilder app)
    {
        return app;
    }

    public static MauiAppBuilder ConfigureGraphicsControls(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers(handlers =>
        {
            handlers.AddTransient(typeof(MyButton), h => new ButtonHandler());
        });

        return builder;
    }
}
