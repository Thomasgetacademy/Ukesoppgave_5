namespace Ukesoppgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Buying 50 T-shirts */
            var shirt = new ClothingItem("Men's T-Shirt", 50, 20.99, "Large", "Blue");

            double shirtSalePrice = shirt.CalculateSalePrice();

            Console.WriteLine($"The sale price of the shirt is: {shirtSalePrice}");

            /* Buying 25 phones */
            var phone = new ElectronicItem("iPhone X", 25, 799.99, "1 year");

            double electronicSalePrice = phone.CalculateSalePrice();

            Console.WriteLine($"The total price of the order is: {electronicSalePrice}");

        }
    }
}