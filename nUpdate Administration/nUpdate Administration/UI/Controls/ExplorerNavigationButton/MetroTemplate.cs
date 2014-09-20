﻿// Author: Dominic Beger (Trade/ProgTrade)
// License: Creative Commons Attribution NoDerivs (CC-ND)
// Created: 01-08-2014 12:11
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ExplorerNavigationButton
{
    public partial class ExplorerNavigationButton
    {
        private class MetroTemplate : Template
        {
            private readonly GraphicsPath arrowPath;
            private readonly RectangleF circleRect;
            private readonly Pen disabledArrowPen;
            private readonly Pen disabledPen;
            private readonly Pen hoverArrowPen;
            private readonly SolidBrush hoverBrush;
            private readonly Pen normalArrowPen;
            private readonly Pen normalPen;
            private readonly SolidBrush pressedBrush;

            public MetroTemplate()
            {
                circleRect = new RectangleF(2.5f, 2.5f, 18f, 18f);

                normalPen = new Pen(Color.FromArgb(100, 100, 100), 1.5f);
                disabledPen = new Pen(Color.FromArgb(200, 200, 200), 1.5f);

                normalArrowPen = new Pen(Color.FromArgb(100, 100, 100), 2);
                hoverArrowPen = new Pen(Color.White, 2);
                disabledArrowPen = new Pen(Color.FromArgb(200, 200, 200), 2);

                arrowPath = new GraphicsPath(FillMode.Alternate);
                var arrowTop = new PointF(7.5f, 11.5f);
                arrowPath.AddLine(new PointF(11.5f, 15.5f), arrowTop);
                arrowPath.AddLine(arrowTop, new PointF(11.5f, 7.5f));
                arrowPath.StartFigure();
                arrowPath.AddLine(arrowTop, new PointF(16.5f, 11.5f));

                hoverBrush = new SolidBrush(Color.FromArgb(50, 152, 254));
                pressedBrush = new SolidBrush(Color.FromArgb(54, 116, 178));
            }

            protected override void DrawNormal(Graphics g, ArrowDirection direction)
            {
                g.DrawEllipse(normalPen, circleRect);
                if (direction == ArrowDirection.Right)
                    g.MultiplyTransform(new Matrix(-1, 0, 0, 1, 23, 0));
                g.DrawPath(normalArrowPen, arrowPath);
            }

            protected override void DrawHover(Graphics g, ArrowDirection direction)
            {
                g.FillEllipse(hoverBrush,
                    new RectangleF(circleRect.X - 0.5f, circleRect.Y - 0.5f, circleRect.Width + 1, circleRect.Height + 1));
                if (direction == ArrowDirection.Right)
                    g.MultiplyTransform(new Matrix(-1, 0, 0, 1, 23, 0));
                g.DrawPath(hoverArrowPen, arrowPath);
            }

            protected override void DrawPressed(Graphics g, ArrowDirection direction)
            {
                g.FillEllipse(pressedBrush,
                    new RectangleF(circleRect.X - 0.5f, circleRect.Y - 0.5f, circleRect.Width + 1, circleRect.Height + 1));
                if (direction == ArrowDirection.Right)
                    g.MultiplyTransform(new Matrix(-1, 0, 0, 1, 23, 0));
                g.DrawPath(hoverArrowPen, arrowPath);
            }

            protected override void DrawDisabled(Graphics g, ArrowDirection direction)
            {
                g.DrawEllipse(disabledPen, circleRect);
                if (direction == ArrowDirection.Right)
                    g.MultiplyTransform(new Matrix(-1, 0, 0, 1, 23, 0));
                g.DrawPath(disabledArrowPen, arrowPath);
            }

            protected override void Dispose(bool disposing)
            {
                normalPen.Dispose();
                normalArrowPen.Dispose();
                arrowPath.Dispose();
                hoverBrush.Dispose();
                hoverArrowPen.Dispose();
                pressedBrush.Dispose();
                disabledArrowPen.Dispose();
                disabledPen.Dispose();

                base.Dispose(disposing);
            }
        }
    }
}