using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PettAssistant.ViewModels
{
    public class AyudaViewModel : BaseViewModel
    {
        public AyudaViewModel()
        {
            Title = "Ayuda";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}