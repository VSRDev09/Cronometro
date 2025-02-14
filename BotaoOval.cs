using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Security.Cryptography.Xml;

namespace Cronometro
{
    public class BotaoOval : Button
    {
        private int BorderRadius = 10; 

        protected override void OnPaint(PaintEventArgs e)
        {
           
            e.Graphics.FillEllipse(new SolidBrush(this.BackColor), this.ClientRectangle);

            
            Color bc = Color.Black;
            Color bg = Color.Gray;
            Color fc = Color.White;
            StringFormat formatter = new StringFormat();

            base.OnPaint(e); 

            formatter.LineAlignment = StringAlignment.Center;
            formatter.Alignment = StringAlignment.Center;
            RectangleF rectangle = new RectangleF(0, 0, e.ClipRectangle.Width, e.ClipRectangle.Height);

            e.Graphics.FillRectangle(new SolidBrush(bg), e.ClipRectangle);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, bc, ButtonBorderStyle.Solid);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(fc), rectangle, formatter);

            if (BorderRadius > 0)
            {
                GraphicsPath gp = Transform.BorderRadius(ClientRectangle, BorderRadius, true, true, true, true); 
                this.Region = new System.Drawing.Region(gp);
            }
        }
    }

    public static class Transform
    {
        public static GraphicsPath BorderRadius(Rectangle rect, int radius, bool isTopLeft, bool isTopRight, bool isBottomLeft, bool isBottomRight)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.X, rect.Y, diameter, diameter);

           
            if (isTopLeft)
            {
                path.AddArc(arc, 180, 90);
            }
            else
            {
                path.AddLine(rect.X, rect.Y + radius, rect.X, rect.Y);
            }

         
            arc.X = rect.X + rect.Width - diameter;
            if (isTopRight)
            {
                path.AddArc(arc, 270, 90);
            }
            else
            {
                path.AddLine(rect.X + rect.Width - radius, rect.Y, rect.X + rect.Width, rect.Y);
            }

            arc.Y = rect.Y + rect.Height - diameter;
            if (isBottomRight)
            {
                path.AddArc(arc, 0, 90);
            }
            else
            {
                path.AddLine(rect.X + rect.Width, rect.Y + rect.Height - radius, rect.X + rect.Width, rect.Y + rect.Height);
            }

            
            arc.X = rect.X;
            if (isBottomLeft)
            {
                path.AddArc(arc, 90, 90);
            }
            else
            {
                path.AddLine(rect.X + radius, rect.Y + rect.Height, rect.X, rect.Y + rect.Height);
            }

            path.CloseFigure();
            return path;
        }
    }
}
