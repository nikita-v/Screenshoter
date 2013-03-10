using System;
using System.Drawing;

namespace Core.Forms
{
    public class ScreenshotReadyEventArgs : EventArgs
    {
        public Bitmap Screenshot
        {
            get;
            private set;
        }

        public ScreenshotReadyEventArgs(Bitmap bitmap)
        {
            Screenshot = bitmap;
        }
    }
}
