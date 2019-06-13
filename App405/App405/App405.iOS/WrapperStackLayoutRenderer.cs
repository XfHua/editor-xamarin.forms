using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App405;
using App405.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(WrapperStackLayout), typeof(WrapperStackLayoutRenderer))]
namespace App405.iOS
{
    public class WrapperStackLayoutRenderer : VisualElementRenderer<StackLayout>
    {
        public WrapperStackLayoutRenderer()
        {
            UIKeyboard.Notifications.ObserveWillShow((sender, args) =>
            {
                if (Element != null)
                {
                    Element.Margin = new Thickness(0, 0, 0, (args.FrameEnd.Height));
                }
            });

            UIKeyboard.Notifications.ObserveWillHide((sender, args) =>
            {
                if (Element != null)
                {
                    Element.Margin = new Thickness(0); //set the margins to zero when keyboard is dismissed
                }
            });
        }
    }
}