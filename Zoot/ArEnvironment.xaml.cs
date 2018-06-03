using System;
using System.Collections.Generic;
using Plugin.Media;
using Xamarin.Forms;

namespace Zoot
{
    public partial class ArEnvironment : ContentPage
    {
#if DEBUG
        public ArEnvironment()
        {
            InitializeComponent();

            currentDevice = null;
            LookingFor.Text += "nothing";
        }
#endif

        public ArEnvironment(Geodevice device)
        {
            InitializeComponent();

            currentDevice = device;
            LookingFor.Text += device.deviceName;

            App.arHandler.OpenCamera();
            App.arHandler.SetGeodevice(currentDevice);
        }

        private Geodevice currentDevice;

        private async void Exit(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
