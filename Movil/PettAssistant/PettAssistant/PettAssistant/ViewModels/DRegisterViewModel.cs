using PettAssistant.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PettAssistant.ViewModels
{
    internal class DRegisterViewModel : BaseViewModel
    {
        public ICommand DLoginCommand { get; set; }
        public ICommand VolverCommand { get; set; }

        public DRegisterViewModel()
        {
            DLoginCommand = new Command(OnLoginClicked);
            VolverCommand = new Command(VolverOp);
        }

        private void OnLoginClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new DLoginPage());
        }

        private void VolverOp()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
