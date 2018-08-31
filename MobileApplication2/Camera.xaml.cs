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
using Windows.Media.Capture;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileApplication2
{

    public sealed partial class Camera : Page
    {
        public Camera()
        {
            this.InitializeComponent();

            // Here is Background Audio when a button is pressed.
            ElementSoundPlayer.State = ElementSoundPlayerState.On;
            ElementSoundPlayer.Volume = 0.2;
        }

        // Functionality for the Take Photo Button
        private async void TakePhoto_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI captureUI = new CameraCaptureUI();
            // PhotoSettings allows you to specify properties for the returned photo e.g. the image format.
            captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
            captureUI.PhotoSettings.CroppedSizeInPixels = new Size(1080, 1920);

            // This method returns a StorageFile instance containing the image if the capture is successful.
            StorageFile photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

            // If the user cancels the capture, the returned object is null.
            if (photo == null)
            {
                // Returns user to camera if the wish.
                return;
            }

        }

        // This gives a function to the 'Return' button.
        // This returns the user to the Home page.
        private void Return(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
