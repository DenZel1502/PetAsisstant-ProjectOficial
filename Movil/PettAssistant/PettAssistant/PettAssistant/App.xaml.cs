using PettAssistant.ViewModels;
using PettAssistant.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PettAssistant
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage( new OpcionPage() );

            // Suscríbete al mensaje "UsuarioAutenticado"
            MessagingCenter.Subscribe<DLoginViewModel>(this, "UsuarioAutenticado", (sender) =>
            {
                // Cambia la MainPage a AppShell cuando se recibe el mensaje
                MainPage = new AppShell();
            });

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
