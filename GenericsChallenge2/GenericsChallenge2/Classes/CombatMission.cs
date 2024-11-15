using GenericsChallenge2.Interfaces;

namespace GenericsChallenge2.Classes
{
    public class CombatMission<T> : Mission<T> where T : IStrength
    {
        public CombatMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
