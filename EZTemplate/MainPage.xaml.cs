/*__ ____  _             
| __|_  / /_\  _ __ _ __ 
| _| / / / _ \| '_ \ '_ \
|___/___/_/ \_\ .__/ .__/
|  \/  |__ _| |_|__|_| _ 
| |\/| / _` | / / -_) '_|
|_|  |_\__,_|_\_\___|_|
 
(C)2022-2023 Derlidio Siqueira - Expoente Zero */

using EZAppMaker.Components;
using EZAppMaker.Support;

namespace EZTemplate
{
    public partial class MainPage : EZContentView
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
    }
}