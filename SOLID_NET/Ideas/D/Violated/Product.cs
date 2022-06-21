namespace SOLID_NET.Ideas.D.Violated
{
    internal class Product
    {
        public string Name { get; set; }

        // violation:
        // High level modules should not depend on low level modules; both should depend on abstractions
        // Abstractions should not depend on details.        // 
        // Abstraction(at this scope it is Product abstract/struct) depend not depend on details.
        public Transport Transport { get; set; }

        public void Move()
        {
            Transport.Move("LA");
        }
    }

    internal class Transport
    {
        public void Move(string address)
        {
            Console.WriteLine($"Movig product to {address}...");
        }
    }
}
