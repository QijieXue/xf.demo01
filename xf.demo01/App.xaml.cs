using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xf.demo01.Services;
using xf.demo01.Views;


using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace xf.demo01
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=2ea114b8-c51a-4f38-9171-54e04fcd063b;" +
                  "ios=6a6edff1-af5c-45a8-a92b-45a4fcd8b87f;" +
                  "uwp={Your UWP App secret here}",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
