using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace M2LinkXamarin
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public App()
        {
            InitializeComponent();

           // MainPage = new MainPage();
            MainPage = new LoginPage();
            if (!IsUserLoggedIn)
            {
                MainPage = new LoginPage();
            }
            else
            {
                //..........................
                MainPage = new NavigationPage(new LoginPage());
            }
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
