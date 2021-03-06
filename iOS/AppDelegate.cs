﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Lottie.Forms.iOS.Renderers;

namespace LottieBit.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            AnimationViewRenderer.Init();

            return base.FinishedLaunching(app, options);
        }
    }
}
