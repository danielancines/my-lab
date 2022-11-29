using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Maui.CustomControls.Config;
using Maui.CustomControls.Views;
using Microsoft.Extensions.Logging;

namespace Maui.CustomControls;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.RegisterViewModels()
			.RegisterViews()
			.UseMauiCommunityToolkitMarkup()
			.UseMauiCommunityToolkit()
			.ConfigureGraphicsControls()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		Routing.RegisterRoute("MainPageViewXaml", typeof(MainPageViewXaml));

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
