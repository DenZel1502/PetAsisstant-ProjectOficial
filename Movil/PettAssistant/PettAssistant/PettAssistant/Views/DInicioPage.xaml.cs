﻿using PettAssistant.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PettAssistant.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DInicioPage : ContentPage
    {
        public DInicioPage()
        {
            InitializeComponent();
            this.BindingContext = new DInicioViewModel();
        }
    }
}