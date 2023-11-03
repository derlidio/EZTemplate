using Microsoft.Extensions.Logging;

using EZAppMaker;
using EZAppMaker.Effects;
using EZAppMaker.Bridges;

namespace EZTemplate;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder
		.UseMauiApp<App>()
        .ConfigureMauiHandlers
        (
            handlers =>
            {
                handlers.AddHandler(typeof(EZScrollBridge), typeof(EZScrollViewHandler));
            }
        )
        .ConfigureEffects
        (
            effects =>
            {
                effects.Add<TouchRoutingEffect, TouchPlatformEffect>();
            }
        )
		.ConfigureFonts
        (
            fonts =>
		    {
			    fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                fonts.AddFont("OpenSans-BoldItalic.ttf", "OpenSansBoldItalic");
                fonts.AddFont("OpenSans-ExtraBold.ttf", "OpenSansExtraBold");
                fonts.AddFont("OpenSans-ExtraBoldItalic.ttf", "OpenSansExtraBoldItalic");
                fonts.AddFont("OpenSans-Italic.ttf", "OpenSansItalic");
                fonts.AddFont("OpenSans-Light.ttf", "OpenSansLight");
                fonts.AddFont("OpenSans-LightItalic.ttf", "OpenSansLightItalic");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("OpenSans-SemiboldItalic.ttf", "OpenSansSemiboldItalic");
                fonts.AddFont("CourierNew.ttf", "CourierNew");
            }
        );

#if DEBUG
		builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}