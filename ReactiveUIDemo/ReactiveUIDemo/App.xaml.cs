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

            new AppBootstrapper();

            MainPage = new ValidationDemoPage();
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
