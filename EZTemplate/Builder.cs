/*__ ____  _             
| __|_  / /_\  _ __ _ __ 
| _| / / / _ \| '_ \ '_ \
|___/___/_/ \_\ .__/ .__/
|  \/  |__ _| |_|__|_| _ 
| |\/| / _` | / / -_) '_|
|_|  |_\__,_|_\_\___|_|
 
(C)2022 Derlidio Siqueira - Expoente Zero */

using EZTemplate.Views;

using EZAppMaker;
using EZAppMaker.Components;
using EZAppMaker.Support;
using EZForms;

namespace EZTemplate
{
    public class Builder: EZBuilder
    {
        private static MainPage main;

        const string db = "sample.db";

        public override void BeforeStart()
        {
            System.Diagnostics.Debug.WriteLine("Builder.BeforeStart()");

            // +---------------------------------------------------------------------+
            // | This method will be called from the App Class Constructor. You MUST |
            // | return from it as quickly as possible. If the App's Constructor do  |
            // | not finish in a short amount of time the Operating System may end   |
            // | the App's process due to timeout!                                   |
            // +---------------------------------------------------------------------+

            // Use this method to set defaults for your App:

            EZSettings.AppName = "EZAppMaker Demo";
            EZSettings.SmoothTransitions = false;

            // If you intend to use EZForms throughout your application, you
            // may want to load your forms' definitions here. If your app doesn't
            // need EZForms, remove it and it's references from your solution.

            EZFormsBuilder.Load("EZTemplate.Assets.XML.forms.xml");

            // The sample database template (empty database, sctructure only) is
            // stored as an embedded resource. If it has not yet been dumped to
            // the App folder, do it now:

            if (!EZLocalAppData.FileExists("sample.db"))
            {
                EZEmbedded.DumpToAppFolder("EZTemplate.Assets.Database.sample.db", "sample.db");
            }
        }

        public override EZContentView BuildMainPage()
        {
            System.Diagnostics.Debug.WriteLine("Builder.BildMainPage()");

            // Here you must return the ContentView wich contains your main page layout.
            // Note that EZAppMaker base layout is an AbsoluteLayout. Your ContentView
            // dimensions (WidthRequest and HeightRequest) will be set to the available
            // screen space minus iOS/Android fringe (safe area).

            main = new MainPage();

            return main;
        }

        public override void BuildMenu(EZMenu menu)
        {
            System.Diagnostics.Debug.WriteLine("Builder.BuildMenu()");

            // If you want to use EZMenu Component, you must return
            // a list containing the identifiers and labels for the
            // menu items. You can also provide an icon to accompain
            // the item label in form of a GeometryGroup (SVG Path).

            List<EZMenuItem> items = new List<EZMenuItem>()
            {
                new EZMenuItem()
                {
                    ItemId = "HomeView",
                    Label = "Home",
                    Icon = EZEmbedded.GetPath("EZTemplate.Assets.Paths.home.txt")
                },

                new EZMenuItem()
                {
                    ItemId = "LicenseView",
                    Label = "License",
                    Icon = EZEmbedded.GetPath("EZTemplate.Assets.Paths.license.txt")
                },

                new EZMenuItem()
                {
                    ItemId = "ComponentsView",
                    Label = "Components",
                    Icon = EZEmbedded.GetPath("EZTemplate.Assets.Paths.form.txt")
                },

                new EZMenuItem()
                {
                    ItemId = "FormSample",
                    Label = "EZForms Sample",
                    Icon = EZEmbedded.GetPath("EZTemplate.Assets.Paths.form.txt")
                },

                new EZMenuItem()
                {
                    ItemId = "FormClass",
                    Label = "Class Binded Form Sample",
                    Icon = EZEmbedded.GetPath("EZTemplate.Assets.Paths.form.txt")
                }
            };

            menu.ItemsSource = items;

            // You may want to set a Margin and Padding for the menu...

            menu.Padding = 10;
            menu.Margin = 10;

            // ... and define where it'll be displayed:

            menu.SlideFrom = EZMenuSlide.Left;
            menu.Alignment = EZMenuAlignment.Top;
        }

        public override EZContentView BuildContentView(string id)
        {
            System.Diagnostics.Debug.WriteLine($"Builder.BuildContentView({id})");

            // Here you must return the ContentView wich corresponds to the given id.
            // EZAppMaker will put the view on the top of the ContentView stack (make
            // the page visible). If it already exists on the stack but is not at the
            // top, EZAppMaker will just raise it and this method will not be called.

            EZContentView view = null;

            switch (id)
            {
                case "HomeView": view = new HomeView(); break;
                case "LicenseView": view = new LicenseView(); break;
                case "ComponentsView": view = new ComponentsView(); break;
                case "FormSample": view = new EZForm(id, db, "frm_sample"); break;
                case "FormClass": view = new EZForm(id, db, "frm_class"); break;

                default: break;
            }

            return view;
        }

        public override string BuildTheme(AppTheme requested)
        {
            System.Diagnostics.Debug.WriteLine("Builder.BuildTheme()");

            // If you want to override EZAppMaker themes, then you must
            // return a JSon with the same structure found in dark.json
            // or light.json at EZAppMaker.Defaults.Data folder.
            // Otherwise just return null.

            string json = null;

            switch (requested)
            {
                case AppTheme.Light:

                    // Load your light theme here

                    break;

                case AppTheme.Dark:

                    // Load your dark theme here

                    break;
            }

            return json;
        }

        public override string BuildLocalization()
        {
            System.Diagnostics.Debug.WriteLine("Builder.BuildLocalization()");

            // If you want to change EZAppMaker default messages
            // and alert buttons text, return a JSon using the
            // same structure found in localization.json
            // at EZAppMaker.Defaults.Data folder.

            return null;
        }

        public override void ThemeChanged()
        {
            System.Diagnostics.Debug.WriteLine("Builder.ThemeChanged()");

            // Do things that deppend on the current theme.
            // In order to know what theme is active, inspect:
            // App.Current.RequestedTheme.
        }

        public override void OrientationChanged(EZOrientation orientation)
        {
            System.Diagnostics.Debug.WriteLine("Builder.OrientationChanged()");

            // Do things that deppend on the current device orientation.
        }

        public override void CurrentViewChanged(EZContentView view)
        {
            System.Diagnostics.Debug.WriteLine("Builder.CurrentViewChanged()");

            // This method will be called whenever a view is set
            // to the top of the ContentView stack. Here we are
            // setting the "page title area" of our main page to
            // reflect the title of the page being viewed:

            if (view != null)
            {
                main.SetTitle(view.Title);
                return;
            }

            main.SetTitle("");
        }
    }
}