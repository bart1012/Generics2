using GenericsChallenge2.Enums;
using GenericsChallenge2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsChallenge2.Classes
{
    internal class Tank : Superhero, IFly, IStrength
    {
        public double FlightSpeed { get; set; }
        public double MaxHeight { get; set; }
        public int StrengthLevel { get; set; }
        public Tank(
            double flightSpeed,
            double maxHeight,
            int strengthLevel,
            string alias,
            string secretIdentity,
            int age,
            Alignment alignment
            )
            : base(alias, secretIdentity, age, alignment)
        {
            FlightSpeed = flightSpeed;
            MaxHeight = maxHeight;
            StrengthLevel = strengthLevel;
        }
    }
}
