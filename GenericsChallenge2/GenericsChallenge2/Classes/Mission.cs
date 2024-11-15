namespace GenericsChallenge2.Classes
{
    abstract class Mission<T>
    {
        public string Location { get; private set; }
        public int Reward { get; private set; }
        public List<T> HeroesDeployed { get; }
    }
}


