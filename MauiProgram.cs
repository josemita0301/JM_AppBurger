using JM_AppBurger.JM_Data;

namespace JM_AppBurger;

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
        string dbPath = JM_FileAccessHelper.GetLocalFilePath("burger.db3");
        builder.Services.AddSingleton<JM_BurgerDatabase>(s => ActivatorUtilities.CreateInstance<JM_BurgerDatabase>(s, dbPath));
        return builder.Build();
	}
}
