namespace Maui.CustomControls.Models;

public class Product
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Description { get; init; }
    public string Name { get; init; }
    public float Price { get; init; }
}
