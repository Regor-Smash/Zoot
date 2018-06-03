using System;
using Wikitude.Architect;
using Android.Hardware;

[assembly: Xamarin.Forms.Dependency(typeof(Zoot.Droid.AndroidArHandler))]

namespace Zoot.Droid
{
    public class AndroidArHandler: IARHandler
    {
        public void OpenCamera()
        {
            //Open the camera stream for AR
            Camera cam = Camera.Open();
            cam.StartPreview();
            /*Android.Hardware.Camera2.CameraDevice f;
            f.CreateCaptureSession();*/
        }

        public void SetGeodevice (Geodevice device)
        {
            //Set the Geodevice to be tracked in this AR
        }
    }
}
