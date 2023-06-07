namespace Ukesoppgave_5;

public abstract class InventoryItem : ISellable
{
    protected string Name;
    protected int Quantity;
    protected double Price;

    public InventoryItem(string name, int quantity, double price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }

    public abstract double CalculateSalePrice();
}