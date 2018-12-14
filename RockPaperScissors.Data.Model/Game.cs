﻿namespace RockPaperScissors.Data.Model
{
    using System;
    using RockPaperScissors.Data.Model.Enums;

    public class Game
    {
        public Guid Id { get; set; }

        public Player FirstPlayer { get; set; }

        public Player SecondPlayer { get; set; }

        public GameStatus Status { get; set; }
    }
}