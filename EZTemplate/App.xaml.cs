using Microsoft.Maui.Handlers;

using EZAppMaker;
using EZAppMaker.Support;

namespace EZTemplate;

public partial class App : Application
{
	public App()
	{
        InitializeComponent();

        EntryHandler.Mapper.AppendToMapping("EZEntryBridge", EZHandlers.EZEntryHandler); /* FEATURE */
        ScrollViewHandler.Mapper.AppendToMapping("EZScrollBridge", EZHandlers.EZScrollTouchHandler); /* FEATURE */
        ScrollViewHandler.Mapper.AppendToMapping("ContentSize", EZHandlers.EZScrollContentSizeHandler); /* WORKAROUND */

        EZApp.Initialize(new Builder());

        MainPage = EZApp.MainPage;
	}
}