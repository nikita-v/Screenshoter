using System.Drawing;
using System.Windows.Forms;

namespace Core.Forms
{
    public partial class EditScreenshotForm : Form
    {
        public delegate void ScreenshotReadyHandler(object sender, ScreenshotReadyEventArgs eventArgs);

        public event ScreenshotReadyHandler ScreenshotReady;

        public EditScreenshotForm()
        {
            InitializeComponent();
        }

        public void Show(Bitmap bitmap)
        {
            screenshotControl.Image = bitmap;
            screenshotControl.ClearSelection();
            screenshotControl.ClearLines();
            Width = bitmap.Width;
            Height = bitmap.Height;
            Show();
        }

        private Bitmap GetResultImage()
        {
            return screenshotControl.GetResultImage();
        }

        private void EditScreenshotFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                screenshotControl.UndoLine();
            }
            else if (e.KeyCode == Keys.Space)
            {
                Close();
                if (ScreenshotReady != null)
                {
                    var eventArgs = new ScreenshotReadyEventArgs(GetResultImage());
                    ScreenshotReady(this, eventArgs);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
