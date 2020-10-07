using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace customTap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyTabs();
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
