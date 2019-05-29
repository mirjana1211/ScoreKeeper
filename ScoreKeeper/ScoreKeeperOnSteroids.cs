using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreKeeper
{
    public class ScoreKeeperOnSteroids
    {
        private readonly IDojoConsole _dojoConsole;
        public ScoreKeeperOnSteroids(IDojoConsole dojoConsole)
        {
            ResultA = new Score(0);
            ResultB = new Score(0);

            _dojoConsole = dojoConsole;
        }
        public Score ResultA { get; private set; }
        public Score ResultB { get; private set; }
        public void PrintScore()
        {

            _dojoConsole.PrintResult($"{ResultA.Value:D3}:{ResultB.Value:D3}");
        }

        public void ScoreTeamA1()
        {
            ResultA = ResultA.IncrementBy(1);
        }

        public void ScoreTeamA2()
        {
            ResultA = ResultA.IncrementBy(2);
        }

        public void ScoreTeamA3()
        {
            ResultA = ResultA.IncrementBy(3);
        }

        public void ScoreTeamB1()
        {
            ResultB = ResultB.IncrementBy(1);
        }

        public void ScoreTeamB2()
        {
            ResultB = ResultB.IncrementBy(2);
        }

        public void ScoreTeamB3()
        {
            ResultB = ResultB.IncrementBy(3);
        }
    }

    public class Score
    {
        public Score(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("value must be a positive number");
            }

            if (value > 999)
            {
                throw new ArgumentException("Score must not be higher than 999");
            }

            Value = value;
        }
        public int Value { get; private set; }

        public Score IncrementBy(int increment)
        {
            if (increment < 1 || increment > 3)
            {
                throw new ArgumentException($"Increment {increment} is not allowed");
            }
            return new Score(Value + increment);
        }
    }
}
