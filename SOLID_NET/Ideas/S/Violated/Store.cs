namespace SOLID_NET.Ideas.S.Violated
{
    internal class Store
    {
        private readonly List<Product> products = new();

        // violation. Because method contains a lot of code from different aspects.
        public void Process()
        {
            Console.WriteLine("Enter product name:");
            string? model = Console.ReadLine();

            Console.WriteLine("Enter product price:");
            bool result = int.TryParse(Console.ReadLine(), out var price);

            if (result == false || price <= 0 || string.IsNullOrEmpty(model))
            {
                throw new Exception("Invalid input");
            }

            products.Add(new Product(model, price));

            using StreamWriter writer = new("store.txt", true);
            writer.WriteLine(model);
            writer.WriteLine(price);
        }
    }
}
