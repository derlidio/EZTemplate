using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EZAppMaker;
using EZAppMaker.Support;

namespace EZTemplate
{
    public partial class App : Application
    {
        public App()
        {
            Builder.BeforeStart();
            
            InitializeComponent();

            MainPage = new EZMainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}