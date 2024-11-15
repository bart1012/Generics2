namespace GenericsChallenge2.Interfaces
{
    public interface IFly
    {
        public double FlightSpeed { get; set; }
        public double MaxHeight { get; set; }

        void Fly(string alias)
        {
            Console.WriteLine($"{alias} swoops by look at them go!");
        }

    }
}
