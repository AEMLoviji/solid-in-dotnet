namespace SOLID_NET.Ideas.D.Fixed
{
    internal class Product
    {
        private readonly ITransport _transport;

        public string Name { get; init; }

        public Product(string name, ITransport transport)
        {
            Name = name;
            _transport = transport;
        }      

        public void MoveTo(string address)
        {
            _transport.Move(address);
        }
    }

    interface ITransport
    {
        void Move(string address);
    }

    internal class Car : ITransport
    {
        public void Move(string address)
        {
            Console.WriteLine($"Movig product to {address}...");
        }
    }

    internal class Ship : ITransport
    {
        public void Move(string address)
        {
            Console.WriteLine($"Movig product to {address}...");
        }
    }
}
