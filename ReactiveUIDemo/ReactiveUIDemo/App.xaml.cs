using ReactiveUIDemo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReactiveUIDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var bootStrapper = new AppBootstrapper();

            MainPage = bootStrapper.CreateMainPage();
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
