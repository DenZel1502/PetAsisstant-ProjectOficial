using PettAssistant.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace PettAssistant.Views
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            Pin MiUbi = new Pin()
            {
                Type = PinType.Place,
                Label = "Mi Ubicacion",
                Address = "Av. Globo Terráqueo 3512, San Martín de Porres 15311",
                Position = new Position(-12.000521750624953, -77.06209627111522),
                Tag = "id_miubi",
            };

            Pin MiUbi2 = new Pin()
            {
                Type = PinType.Place,
                Label = "Mi Ubicacion",
                Address = "Av. Globo Terráqueo 3512, San Martín de Porres 15311",
                Position = new Position(-12.000663, -77.061356),
                Tag = "id_miubi",
                
            };

            map.Pins.Add(MiUbi);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(MiUbi.Position, Distance.FromMeters(500)));

            map.Pins.Add(MiUbi2);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(MiUbi2.Position, Distance.FromMeters(500)));
        }
    }
}