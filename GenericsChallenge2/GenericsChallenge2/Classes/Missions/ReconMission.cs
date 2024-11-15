using GenericsChallenge2.Interfaces;

namespace GenericsChallenge2.Classes.Missions
{
    public class ReconMission<T> : Mission<T> where T : IFly
    {
        public ReconMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
