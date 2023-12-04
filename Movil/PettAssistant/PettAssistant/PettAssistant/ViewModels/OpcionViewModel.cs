using PettAssistant.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PettAssistant.ViewModels
{
    internal class OpcionViewModel : BaseViewModel
    {

        public ICommand NavegarPDuenio { get; set; }
        public ICommand NavegarPCuidador { get; set; }

        public OpcionViewModel()
        {
            Title = "Menú";
            NavegarPDuenio = new Command(DLoginPage);

        }

        private void DLoginPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new DInicioPage());
        }

    }
}
