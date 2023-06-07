namespace Ukesoppgave_5;

public class ElectronicItem : InventoryItem
{
    private string _insuranceInformation;

    public ElectronicItem(string name, int quantity, double price, string insuranceInformation) : base(name, quantity, price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
        _insuranceInformation = insuranceInformation;
    }

    public override double CalculateSalePrice()
    {
        return Price * Quantity;
    }
}
