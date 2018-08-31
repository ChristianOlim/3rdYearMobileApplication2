using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileApplication2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Coordinates : Page
    {
        public static Geolocator Geolocator { get; set; }
        public static bool RunningInBackground { get; set; }
        public Coordinates()
        {
            this.InitializeComponent();
            SetupGeo();

            // Here is Background Audio when a button is pressed.
            ElementSoundPlayer.State = ElementSoundPlayerState.On;
            ElementSoundPlayer.Volume = 0.2;
        }

        private void SetupGeo()
        {
            if (Geolocator == null)
            {
                Geolocator = new Geolocator();
                Geolocator.DesiredAccuracy = PositionAccuracy.High;
                Geolocator.MovementThreshold = 100; // The units are meters.
                Geolocator.PositionChanged += Geolocator_PositionChanged;
            }
        }

        private void Geolocator_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            geolocator_PositionChanged(sender, args);
        }

        private async void geolocator_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {   //Point point;
                //point.Position.Latitude
                LatitudeTextBlock.Text = args.Position.Coordinate.Latitude.ToString("0.00");
                LongitudeTextBlock.Text = args.Position.Coordinate.Longitude.ToString("0.00");
            });

        }

        // This gives a function to the 'Return' button.
        // This returns the user to the Home page.
        private void Return(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}