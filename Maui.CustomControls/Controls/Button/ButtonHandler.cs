using Maui.CustomControls.Controls.Button.Core;
using Microsoft.Maui.Handlers;

namespace Maui.CustomControls.Controls.Button
{
    public partial class ButtonHandler : GraphicsViewHandler
    {
        public ButtonHandler() : base(PropertyMapper)
        {
        }

        private static IPropertyMapper<MyButton, ButtonHandler> PropertyMapper = new PropertyMapper<MyButton, ButtonHandler>(GraphicsViewHandler.Mapper)
        {
            [nameof(MyButton.BackgroundColor)] = MapBackgroundColor,
            [nameof(MyButton.Text)] = MapText
        };

        public static void MapBackgroundColor(ButtonHandler handler, MyButton button)
        {
            if (button.Drawable is IMyButtonDrawable drawable)
                drawable.BackgroundColor = button.BackgroundColor;
            
            button.Invalidate();
        }

        public static void MapText(ButtonHandler handler, MyButton button)
        {
            if (button.Drawable is IMyButtonDrawable drawable)
                drawable.Text = button.Text;

            button.Invalidate();
        }
    }
}
