using GenericsChallenge2.Enums;
using GenericsChallenge2.Interfaces;

namespace GenericsChallenge2.Classes
{
    internal class Gadgeteer : Superhero, ITech, IStrength
    {
        public string Gadget { get; set; }
        public int StrengthLevel { get; set; }

        public Gadgeteer(
            string gadget,
            int strengthLevel,
            string alias,
            string secretIdentity,
            int age,
            Alignment alignment
            )
            : base(alias, secretIdentity, age, alignment)
        {
            Gadget = gadget;
            StrengthLevel = strengthLevel;
        }
    }
}
