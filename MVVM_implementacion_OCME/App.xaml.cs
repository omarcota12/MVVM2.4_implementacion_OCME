using MVVM_implementacion_OCME.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_OCME
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pagina1());
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
