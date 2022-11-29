using Maui.CustomControls.Controls.Button.Core;
using Microsoft.Maui.Graphics;

namespace Maui.CustomControls.Controls.Button;

public class RegularButtonDrawable : IMyButtonDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.FillColor = this.BackgroundColor;
        canvas.FillRectangle(dirtyRect);
        canvas.FontSize = 14;
        canvas.DrawString(this.Text, dirtyRect, HorizontalAlignment.Left, VerticalAlignment.Center);
    }

    public Color BackgroundColor { get; set; } = Colors.White;
    public string Text { get; set; }
}
