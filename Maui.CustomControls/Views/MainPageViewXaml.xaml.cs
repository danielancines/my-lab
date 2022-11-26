using Maui.CustomControls.ViewModels;

namespace Maui.CustomControls.Views;

public partial class MainPageViewXaml : ContentPage
{
	public MainPageViewXaml(MainPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}