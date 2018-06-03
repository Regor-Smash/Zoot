using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Zoot
{
    public partial class DeviceSelect : ContentPage
    {
        public DeviceSelect()
        {
            InitializeComponent();

            CreateButtons();
        }

        private void CreateButtons ()
        {
            for (int i = 0; i < GeodeviceManager.allDevices.Count; i++)
            {
                Button deviceButton = new Button();
                deviceButton.Text = GeodeviceManager.allDevices[i].deviceName;
                deviceButton.Clicked += OpenAR;
                deviceButton.HorizontalOptions = LayoutOptions.CenterAndExpand;
                deviceButton.VerticalOptions = LayoutOptions.Start;

                ButtonLayout.Children.Add(deviceButton);
            }
        }

        async void OpenAR(object sender, EventArgs e)
        {
            //Open the AR environment
            Button button = sender as Button;

            Geodevice selected = GeodeviceManager.FindDevice(button.Text);
            if (selected != null)
            {
                await Navigation.PushAsync(new ArEnvironment(selected));
            }
            else
            {
                await DisplayAlert("Invalid Device", "The device you selected could not be found.", "OK");
            }
        }

        void ManageDevices(object sender, EventArgs e)
        {
            //Open the geodevice managment screen
            Button button = sender as Button;

            //await Navigation.PushAsync();
        }
    }
}
