using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Maui.CustomControls.Models;
using System.Collections.ObjectModel;

namespace Maui.CustomControls.ViewModels;

public partial class MainPageViewModel : ObservableObject, IRecipient<ProductViewModel>
{
    public MainPageViewModel()
    {
        WeakReferenceMessenger.Default.Register(this);
    }
    public ObservableCollection<ProductViewModel> Products { get; } = new ObservableCollection<ProductViewModel>();

    [RelayCommand]
    private void AddProduct()
    {
        this.Products.Add(new ProductViewModel(new Product { Name = this.Name, Description = this.Description, Price = this.Price }));
    }

    [ObservableProperty]
    private string name;

    [ObservableProperty]
    private string description;

    [ObservableProperty]
    private float price;

    public void Receive(ProductViewModel productViewModel)
    {
        this.Products.Remove(productViewModel);
    }
}
