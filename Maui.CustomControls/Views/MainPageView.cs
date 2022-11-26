using CommunityToolkit.Maui.Markup;
using Maui.CustomControls.Controls;
using Maui.CustomControls.ViewModels;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace Maui.CustomControls.Views;

public class MainPageView : ContentPage
{
    public MainPageView(MainPageViewModel viewModel)
    {
        this.BindingContext = viewModel;
        this.Title = "Maui Custom Controls App";

        Content = new Grid
        {
            RowDefinitions = Rows.Define(
                        Star,
                        Auto,
                        Auto),

            Children =
            {
                new DataGridView
                {

                }.Bind(ItemsView.ItemsSourceProperty, nameof(viewModel.Products))
                .ItemTemplate(new DataTemplate(() =>
                {
                    return new Grid
                    {
                        ColumnDefinitions = Columns.Define(Star, Star, Auto),
                        Children =
                        {
                            new Label().Bind(Label.TextProperty, "Product.Name"),
                            new Label().Bind(Label.TextProperty, "Product.Description")
                            .Column(1),
                            new Button() { Text = "Excluir" }.Column(2).Bind(Button.CommandProperty, "DeleteCommand").Bind(Button.CommandParameterProperty, "Product")
                        }
                    };
                })),
                new HorizontalStackLayout
                {
                    Children =
                    {
                        new Entry
                        {
                            Placeholder = "Product Nome",
                            TextColor = Colors.Red
                        }.Bind(Entry.TextProperty, "Name"),
                        new Entry
                        {
                            Placeholder = "Product Description  1",
                            TextColor = Colors.Yellow
                        }.Bind(Entry.TextProperty, "Description"),
                        new Entry
                        {
                            Placeholder = "Product Price"
                        }.Bind(Entry.TextProperty, "Price")
                    }
                }.Row(1),

                new Button
                {
                    Text = "Add Product"
                }.Bind(Button.CommandProperty, nameof(viewModel.AddProductCommand))
                .Row(2)
            }
        };

        Shell.Current.GoToAsync("MainPageViewXaml");
    }
}
