using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Maui.CustomControls.Models;

namespace Maui.CustomControls.ViewModels;

public partial class ProductViewModel : ObservableObject
{
    [ObservableProperty]
    private Product product;
    public ProductViewModel(Product product)
    {
        this.Product = product;
    }

    [RelayCommand]
    private void Delete(Product product)
    {
        WeakReferenceMessenger.Default.Send(this);
    }
}
