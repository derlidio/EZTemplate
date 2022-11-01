/*__ ____  _             
| __|_  / /_\  _ __ _ __ 
| _| / / / _ \| '_ \ '_ \
|___/___/_/ \_\ .__/ .__/
|  \/  |__ _| |_|__|_| _ 
| |\/| / _` | / / -_) '_|
|_|  |_\__,_|_\_\___|_|
 
(C)2022 Derlidio Siqueira - Expoente Zero */

using Xamarin.Forms;

using EZAppMaker.Components;
using EZAppMaker.Support;
using System;

namespace EZTemplate
{
    public partial class MainPage : ContentView
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            PageTitle.Text = title;
        }

        private void OnMenuTap(EZPathButton button)
        {
            if (EZApp.Container.IsMenuVisible)
            {
                EZApp.Container.HideMenu();
                return;
            }

            EZApp.Container.ShowMenu();
        }

        private async void OnCloseTap(EZPathButton button)
        {
            if (EZApp.Container.IsMenuVisible)
            {
                EZApp.Container.HideMenu();
                return;
            }

            await EZApp.Container.PopContentView();
        }

        private void ThemeChanged()
        {
            if (Application.Current.RequestedTheme == OSAppTheme.Dark)
            {

            }
            else
            {

            }
        }

    }
}
