namespace GenericsChallenge2.Interfaces
{
    public interface IStrength
    {
        public int StrengthLevel { get; set; }

        void Lift(string alias)
        {
            Console.WriteLine($"{alias} lifts with all their might!");
        }
    }
}
