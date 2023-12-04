﻿using PettAssistant.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PettAssistant.ViewModels
{
    internal class DInicioViewModel : BaseViewModel
    {
        public ICommand DLoginCommand { get; set; }
        public ICommand VolverCommand { get; set; }

        public DInicioViewModel()
        {
            DLoginCommand = new Command(DLoginClicked);
            VolverCommand = new Command(VolverOp);
        }

        private void DLoginClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new DLoginPage());
        }

        private void VolverOp()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
