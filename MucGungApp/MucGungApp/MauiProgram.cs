using Microsoft.Maui.Controls.Compatibility.Hosting;
namespace MucGungApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("fallingsky.otf", "Fallingsky");
                fonts.AddFont("fallingskybd.otf", "Fallingsky Bold");
                fonts.AddFont("fallingskylight.otf", "Fallingsky Light");
            });

		return builder.Build();
	}
}
