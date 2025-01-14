using System.Diagnostics;
using Foundation;
using UIKit;
using UserNotifications;

namespace RegelApp
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp()
        {


            return MauiProgram.CreateMauiApp();
        }



    }
}