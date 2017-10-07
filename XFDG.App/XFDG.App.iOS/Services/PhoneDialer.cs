
using Foundation;
using UIKit;
using XFDG.App.Core;

namespace XFDG.App.iOS.Services
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number));
        }
    }
}