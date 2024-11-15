﻿namespace GenericsChallenge2.Interfaces
{
    public interface ITech
    {
        public string Gadget { get; protected set; }

        void Hack(string alias)
        {
            Console.WriteLine($"{alias} is hacking into the mainframe!");
        }
    }
}