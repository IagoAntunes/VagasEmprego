using System;
using VagasEmprego.Paginas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VagasEmprego
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ConsultaVagas();
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
