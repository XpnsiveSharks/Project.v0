using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class rndLabel : Label
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, 20, 20, 180, 90);
        path.AddArc(Width - 20, 0, 20, 20, 270, 90);
        path.AddArc(Width - 20, Height - 20, 20, 20, 0, 90);
        path.AddArc(0, Height - 20, 20, 20, 90, 90);
        path.CloseFigure();

        this.Region = new Region(path);

        using (Pen pen = new Pen(this.ForeColor, 1))
        {
            e.Graphics.DrawPath(pen, path);
        }
    }
}
