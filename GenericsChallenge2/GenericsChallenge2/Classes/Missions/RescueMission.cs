namespace GenericsChallenge2.Classes.Missions
{
    public class RescueMission<T> : Mission<T>
    {
        public RescueMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
