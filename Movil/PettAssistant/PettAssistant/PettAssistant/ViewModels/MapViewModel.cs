using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PettAssistant.ViewModels
{
    public class MapViewModel:BaseViewModel
    {
        public Command MapCommand { get; }
        public MapViewModel() {
            Title = "Mapa";
        }

        public ICommand OpenWebCommand { get; }
    }
}
