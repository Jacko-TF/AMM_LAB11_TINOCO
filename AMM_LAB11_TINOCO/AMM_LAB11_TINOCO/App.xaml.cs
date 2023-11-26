using AMM_LAB11_TINOCO.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AMM_LAB11_TINOCO
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Sueldo();
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
