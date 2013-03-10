using System.Drawing;
using System.Windows.Forms;

namespace Core.Controls
{
    public partial class ColorViewControl : UserControl
    {
        private Color color;

        public Color CurrentColor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                Invalidate();
            }
        }

        public ColorViewControl()
        {
            InitializeComponent();
            Paint += ColorViewControlPaint;
        }

        private void ColorViewControlPaint(object sender, PaintEventArgs e)
        {
            var brush = new SolidBrush(CurrentColor);
            e.Graphics.FillRectangle(brush, 0, 0, Width, Height);
            e.Graphics.DrawRectangle(Pens.Gray, 0, 0, Width, Height);
        }
    }
}
