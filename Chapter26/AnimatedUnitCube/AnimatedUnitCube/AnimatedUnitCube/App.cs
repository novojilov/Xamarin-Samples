using System;
using Xamarin.Forms;

namespace AnimatedUnitCube
{
    public class App : Application
    {
        public App()
        {
            Xamarin.FormsBook.Toolkit.Toolkit.Init();

            MainPage = new AnimatedUnitCubePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
