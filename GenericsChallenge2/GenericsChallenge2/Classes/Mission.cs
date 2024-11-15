namespace GenericsChallenge2.Classes
{
    public abstract class Mission<T>
    {
        public string Location { get; private set; }
        public int Reward { get; private set; }
        public List<T> HeroesDeployed { get; set; }

        protected Mission(string location, int reward)
        {
            Location = location;
            Reward = reward;
            HeroesDeployed = new List<T>();
        }
    }
}


