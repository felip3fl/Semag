﻿namespace Core.Models
{
    public class Game
    {
        public string Name {get;set;}
        public string Store {get;set;}
        public byte Player {get;set;}
        public bool OnlyLocal {get;set;}
        public bool BetterTogether {get;set;}
        public bool Finish { get; set; }
    }
}
