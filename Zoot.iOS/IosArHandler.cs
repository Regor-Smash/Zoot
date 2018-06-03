using System;

[assembly: Xamarin.Forms.Dependency(typeof(Zoot.iOS.IosArHandler))]

namespace Zoot.iOS
{
    public class IosArHandler: IARHandler
    {
        public void OpenCamera ()
        {
            //Open the camera stream for AR
        }

        public void SetGeodevice (Geodevice device)
        {
            //Set the Geodevice to be tracked in this AR
        }
    }
}
