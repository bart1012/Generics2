namespace GenericsChallenge2.Interfaces
{
    public interface ITelepathy
    {
        public int PowerLevel { get; protected set; }

        void ReadMind(string alias)
        {
            Console.WriteLine($"{alias} is reading your thoughts!");
        }
    }
}
