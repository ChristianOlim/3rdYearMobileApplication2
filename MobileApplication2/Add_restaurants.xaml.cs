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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileApplication2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Add_restaurants : Page
    {
        /*
        const string connString = "id=id; name of restaurant=nor; distance from eyre sqaure(KM)=dfes; rating out of 10=True; database=mydb";

        string loadQuery = "SELECT * FROM restaurantsdb;";
        */

        public Add_restaurants()
        {
            this.InitializeComponent();
        }


        // This gives a function to the 'Return' button.
        // This returns the user to the Home page.
        private void Return(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void gridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}
