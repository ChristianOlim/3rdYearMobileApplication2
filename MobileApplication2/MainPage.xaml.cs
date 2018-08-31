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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MobileApplication2
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Here is Background Audio when a button is pressed.
            ElementSoundPlayer.State = ElementSoundPlayerState.On;
            ElementSoundPlayer.Volume = 0.2;
        }
        /*
                // Here we're making this button functional.
                private void Add_restaurants(object sender, RoutedEventArgs e)
                {

                    // We will send the user to the AddRestaurants page.
                    this.Frame.Navigate(typeof(Add_restaurants));
                }
        */

        // Here we're making this button functional.
        private void Camera(object sender, RoutedEventArgs e)
        {
            // We will send the user to the Camera page.
            this.Frame.Navigate(typeof(Camera));
        }

        // Here we're making this button functional.
        private void Coordinates(object sender, RoutedEventArgs e)
        {
            // We will send the user to the Navigate page.
            this.Frame.Navigate(typeof(Coordinates));
        }

        // Here we're making this button functional.
        private void Add_restaurants(object sender, RoutedEventArgs e)
        {
            // We will send the user to the Navigate page.
            this.Frame.Navigate(typeof(Add_restaurants));
        }
    }
}
