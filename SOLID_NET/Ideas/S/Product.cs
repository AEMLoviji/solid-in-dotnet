namespace SOLID_NET.Ideas.S
{
    internal class Product
    {
        public string Name { get; init; }
        public int Price { get; init; }

        public Product(string name, int price) => (Name, Price) = (name, price);
    }
}
