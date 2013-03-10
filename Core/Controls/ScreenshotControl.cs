using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Core.Properties;

namespace Core.Controls
{
    public partial class ScreenshotControl : PictureBox
    {
        private class Line
        {
            private readonly List<Point> points = new List<Point>();
            public IEnumerable<Point> Points
            {
                get
                {
                    return points;
                }
            }

            public void AddPoint(Point point)
            {
                points.Add(point);
            }
        };

        private enum PointPosition
        {
            LeftTop,
            RightBottom
        };

        private Boolean isLeftButtonPressed;
        private Point startSelectionPoint;
        private Point endSelectionPoint;

        private readonly List<Line> lines = new List<Line>();
        private Line currentLine;

        public ScreenshotControl()
        {
            InitializeComponent();

            MouseDown += MouseDownEvent;
            MouseUp += MouseUpEvent;
            MouseMove += MouseMoveEvent;
        }

        public void ClearSelection()
        {
            startSelectionPoint = new Point();
            endSelectionPoint = new Point();
        }

        public void ClearLines()
        {
            lines.Clear();
        }

        public void UndoLine()
        {
            if (lines.Count != 0)
            {
                lines.RemoveAt(lines.Count - 1);
            }
        }

        public Bitmap GetResultImage()
        {
            var bitmapWithLines = (Bitmap)Image.Clone();
            using (Graphics graphics = Graphics.FromImage(bitmapWithLines))
            {
                PrintLines(graphics);
            }
            return CropImage(bitmapWithLines, new Rectangle(startSelectionPoint,
                new Size(endSelectionPoint.X - startSelectionPoint.X, endSelectionPoint.Y - startSelectionPoint.Y)));
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftButtonPressed = true;
                endSelectionPoint = new Point();
                startSelectionPoint = new Point(e.X, e.Y);
            }
            else if (e.Button == MouseButtons.Right)
            {
                currentLine = new Line();
            }
        }

        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftButtonPressed = false;
                NormalizeSelection();
            }
            else if (e.Button == MouseButtons.Right)
            {
                lines.Add(currentLine);
                currentLine = null;
            }
            Invalidate();
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isLeftButtonPressed)
            {
                endSelectionPoint.X = e.X;
                endSelectionPoint.Y = e.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                currentLine.AddPoint(new Point(e.X, e.Y));
            }
            Invalidate();
        }
        
        protected override void OnPaint(PaintEventArgs paintEvent)
        {
            base.OnPaint(paintEvent);
            PrintSelection(paintEvent.Graphics);
            PrintLines(paintEvent.Graphics);
        }

        private Bitmap CropImage(Bitmap source, Rectangle cropRectngle)
        {
            return source.Clone(cropRectngle, source.PixelFormat);
        }

        private void PrintSelection(Graphics graphics)
        {
            Color fillColor = Color.FromArgb(100, Settings.Default.SelectedBackgroundColor);
            var borderColor = new Pen(Settings.Default.SelectedBorderColor);
            Brush brush = new SolidBrush(fillColor);
            if (startSelectionPoint.IsEmpty || endSelectionPoint.IsEmpty)
            {
                graphics.FillRectangle(brush, new Rectangle(0, 0, Width, Height));
            }
            else
            {
                Point leftTopPoint = GetPoint(PointPosition.LeftTop, startSelectionPoint, endSelectionPoint);
                Point rightBottomPoint = GetPoint(PointPosition.RightBottom, startSelectionPoint, endSelectionPoint);

                graphics.FillRectangle(brush, new Rectangle(0, 0, leftTopPoint.X, Image.Height));
                graphics.FillRectangle(brush, new Rectangle(leftTopPoint.X, 0,
                    rightBottomPoint.X - leftTopPoint.X, leftTopPoint.Y));
                graphics.FillRectangle(brush, new Rectangle(rightBottomPoint.X, 0,
                    Image.Width - rightBottomPoint.X, Image.Height));
                graphics.FillRectangle(brush, new Rectangle(leftTopPoint.X, rightBottomPoint.Y,
                    rightBottomPoint.X - leftTopPoint.X, Image.Height - rightBottomPoint.Y));
                graphics.DrawRectangle(borderColor, new Rectangle(leftTopPoint,
                    new Size(rightBottomPoint.X - leftTopPoint.X, rightBottomPoint.Y - leftTopPoint.Y)));
            }
        }

        private void PrintLines(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            var pen = new Pen(Settings.Default.PenColor, Settings.Default.PenWidth);
            foreach (Line line in lines)
            {
                var prevPoint = new Point();
                foreach (Point point in line.Points)
                {
                    if (!prevPoint.IsEmpty)
                    {
                        graphics.DrawLine(pen, prevPoint, point);
                    }
                    prevPoint = point;
                }
            }
            if (currentLine != null)
            {
                var prevPoint = new Point();
                foreach (Point point in currentLine.Points)
                {
                    if (!prevPoint.IsEmpty)
                    {
                        graphics.DrawLine(pen, prevPoint, point);
                    }
                    prevPoint = point;
                }
            }
        }

        private void NormalizeSelection()
        {
            Point leftTopPoint = GetPoint(PointPosition.LeftTop, startSelectionPoint, endSelectionPoint);
            Point rightBottomPoint = GetPoint(PointPosition.RightBottom, startSelectionPoint, endSelectionPoint);
            startSelectionPoint = leftTopPoint;
            endSelectionPoint = rightBottomPoint;
        }

        private Point GetPoint(PointPosition position, Point first, Point second)
        {
            if (position == PointPosition.LeftTop)
            {
                return new Point(Math.Min(first.X, second.X), Math.Min(first.Y, second.Y));
            }
            return new Point(Math.Max(first.X, second.X), Math.Max(first.Y, second.Y));
        }
    }
}
