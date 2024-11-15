namespace GenericsChallenge2.Interfaces
{
    public interface IStrength
    {
        public int StrengthLevel { get; protected set; }

        void Lift(string alias)
        {
            Console.WriteLine($"{alias} lifts with all their might!");
        }
    }
}
