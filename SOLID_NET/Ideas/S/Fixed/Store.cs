namespace SOLID_NET.Ideas.S.Fixed
{
    internal class Store
    {
        private readonly List<Product> _products = new();

        private readonly IProductReader _reader;
        private readonly IProductBinder _binder;
        private readonly IProductValidator _validator;
        private readonly IProductSaver _saver;

        public Store(
            IProductReader reader,
            IProductBinder binder,
            IProductValidator validator,
            IProductSaver saver)
        {
            _reader = reader;
            _binder = binder;
            _validator = validator;
            _saver = saver;
        }

        public void AddNewProduct()
        {
            string?[] data = _reader.GetInputData();

            Product product = _binder.CreateProduct(data);

            if (!_validator.IsValid(product))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            _products.Add(product);

            _saver.Save(product, "store.txt");

            Console.WriteLine("Success!");
        }
    }

    interface IProductReader
    {
        string?[] GetInputData();
    }

    class ProductReader : IProductReader
    {
        public string?[] GetInputData()
        {
            Console.WriteLine("Enter product name:");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            string? price = Console.ReadLine();
            return new string?[] { name, price };
        }
    }

    interface IProductBinder
    {
        Product CreateProduct(string?[] data);
    }

    class ProductBinder : IProductBinder
    {
        public Product CreateProduct(string?[] data)
        {
            if (data is { Length: 2 } && data[0] is string model &&
                model.Length > 0 && int.TryParse(data[1], out var price))
            {
                return new Product(model, price);
            }

            throw new Exception("Model binding issue. Invalid input");
        }
    }

    interface IProductValidator
    {
        bool IsValid(Product product);
    }

    class ProductValidator : IProductValidator
    {
        public bool IsValid(Product product) => !string.IsNullOrEmpty(product.Name) && product.Price > 0;
    }

    interface IProductSaver
    {
        void Save(Product product, string fileName);
    }

    class TextProductSaver : IProductSaver
    {
        public void Save(Product product, string fileName)
        {
            using StreamWriter writer = new(fileName, true);
            writer.WriteLine(product.Name);
            writer.WriteLine(product.Price);
        }
    }
}
