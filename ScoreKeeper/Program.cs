using System;

namespace ScoreKeeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myConsole = new DojoConsole();
            var scoreKeeper = new ScoreKeeperOnSteroids(myConsole);

            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamB2();
            scoreKeeper.ScoreTeamA3();
            scoreKeeper.ScoreTeamB1();
	    scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamA1();
	    scoreKeeper.ScoreTeamB2();

            scoreKeeper.PrintScore();
            Console.ReadLine();
        }
    }
}
