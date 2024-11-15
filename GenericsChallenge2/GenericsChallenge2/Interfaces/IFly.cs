namespace GenericsChallenge2.Interfaces
{
    public interface IFly
    {
        public double FlightSpeed { get; protected set; }
        public double MaxHeight { get; protected set; }

        void Fly(string alias)
        {
            Console.WriteLine($"{alias} swoops by look at them go!");
        }

    }
}
