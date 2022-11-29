namespace Maui.CustomControls.Controls.Button;

public class MyButton : GraphicsView
{
	public MyButton()
	{
		this.Drawable = new RegularButtonDrawable();
	}

	public static readonly BindableProperty TextProperty =
        BindableProperty.Create("Text", typeof(string), typeof(MyButton));
    public string Text
    {
        get { return (string)GetValue(TextProperty); }
        set { SetValue(TextProperty, value); }
    }
}
