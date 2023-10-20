using Android.App;
using Android.Content.PM;

namespace EZTemplate;

//[Activity(... ScreenOrientation = ScreenOrientation.Landscape)] //This is what controls orientation, you could force the application orientation to be Landscape or Portrait
[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
}