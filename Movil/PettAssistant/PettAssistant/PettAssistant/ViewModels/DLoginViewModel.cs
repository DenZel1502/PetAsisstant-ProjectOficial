using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PettAssistant.ViewModels
{
    internal class DLoginViewModel : BaseViewModel
    {
        public ICommand DLoginCommand { get; set; }
        public ICommand VolverCommand { get; set; }

        public DLoginViewModel()
        {
            DLoginCommand = new Command(OnLoginClicked);
            VolverCommand = new Command(VolverOp);
        }

        private void OnLoginClicked()
        {
            MessagingCenter.Send(this, "UsuarioAutenticado");
        }

        private void VolverOp()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
