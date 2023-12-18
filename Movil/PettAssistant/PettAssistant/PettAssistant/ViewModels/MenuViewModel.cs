using PettAssistant.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PettAssistant.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public ICommand NavegarPMascota { get; set; }
        public ICommand NavegarMPago { get; set; }
        public ICommand NavegarMCuenta { get; set; }
        public ICommand NavegarHistorial { get; set; }
        public ICommand CerrarSesionCommand { get; set; }
        public MenuViewModel()
        {
            Title = "Menú";
            NavegarPMascota = new Command(PMascota);
            NavegarMPago = new Command(MPago);
            NavegarMCuenta = new Command(MCuenta);
            NavegarHistorial = new Command(Historial);

        }

        private void PMascota()
        {
            Application.Current.MainPage.Navigation.PushAsync(new PMascotaPage());
        }
        private void MPago()
        {
            Application.Current.MainPage.Navigation.PushAsync(new MetodoPagoPage());
        }
        private void MCuenta()
        {
            Application.Current.MainPage.Navigation.PushAsync(new DuenioPage());
        }
        private void Historial()
        {
            Application.Current.MainPage.Navigation.PushAsync(new HistorialPage());
        }
    }
}
