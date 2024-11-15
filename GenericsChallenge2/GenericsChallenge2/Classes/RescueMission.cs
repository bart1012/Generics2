using GenericsChallenge2.Interfaces;

namespace GenericsChallenge2.Classes
{
    public class RescueMission<T> : Mission<T> where T : IFly, ITech
    {
        public RescueMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
