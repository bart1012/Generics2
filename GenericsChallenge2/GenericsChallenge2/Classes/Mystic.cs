using GenericsChallenge2.Enums;
using GenericsChallenge2.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsChallenge2.Classes
{
    internal class Mystic : Superhero, IFly, ITelepathy
    {
        public double FlightSpeed { get; set; }
        public double MaxHeight { get; set; }
        public int PowerLevel { get; set; }

        public Mystic(
            double flightSpeed, 
            double maxHeight, 
            int powerLevel, 
            string alias, 
            string secretIdentity, 
            int age, 
            Alignment alignment
            )
            : base(alias, secretIdentity, age, alignment)
        {
            FlightSpeed = flightSpeed;
            MaxHeight = maxHeight;
            PowerLevel = powerLevel;
        }
    }
}
