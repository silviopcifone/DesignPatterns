namespace DesignPatternExample.model
{
    internal class Truck : ITransport
    {
        public int Id = 0;

        public Truck()
        {
            this.Id = GenerateId();
            Console.WriteLine("Truck creato con Id: " + Id);
        }

        public int GenerateId()
        {
            return new Random().Next(1, 100);
        }
    }
}