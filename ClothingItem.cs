using System.Drawing;

namespace Ukesoppgave_5;

public class ClothingItem : InventoryItem
{
    private string _size;
    private string _color;

    public ClothingItem(string name, int quantity, double price, string size, string color) : base(name, quantity, price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
        _size = size;
        _color = color;
    }

    public override double CalculateSalePrice()
    {
        return Price * Quantity;
    }
}