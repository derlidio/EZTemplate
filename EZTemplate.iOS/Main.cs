/*__ ____  _             
| __|_  / /_\  _ __ _ __ 
| _| / / / _ \| '_ \ '_ \
|___/___/_/ \_\ .__/ .__/
|  \/  |__ _| |_|__|_| _ 
| |\/| / _` | / / -_) '_|
|_|  |_\__,_|_\_\___|_|
 
(C)2022 Derlidio Siqueira - Expoente Zero */

using System;

using UIKit;

namespace EZTemplate.iOS
{
    public class Application
    {
        static void Main(string[] args)
        {
            Type principalClass = null;
            Type appDelegate = typeof(AppDelegate);

            UIApplication.Main(args, principalClass, appDelegate);
        }
    }
}