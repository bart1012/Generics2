namespace GenericsChallenge2.Classes
{
    public class CombatMission<T> : Mission<T>
    {
        public CombatMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
