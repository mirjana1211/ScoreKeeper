using NSubstitute;
using NUnit.Framework;
using ScoreKeeper;

namespace Tests
{
    public class ScoreKeeperOnSteroids_Specs
    {
        [Test]
        public void When_GetResult_Called_Should_Return_Result_With_Correct_Length()
        {
            var consoleWriter = Substitute.For<IDojoConsole>();
            //Arrange
            var scoreKeeper = new ScoreKeeperOnSteroids(consoleWriter);

            //Act
            scoreKeeper.PrintScore();

            //Assert
            consoleWriter.Received(1).PrintResult("000:000");
        }


        [Test]
        public void When_GetResult_Called_Should_Return_Properly_Formated_Result()
        {
            var consoleWriter = Substitute.For<IDojoConsole>();
            //Arrange
            var scoreKeeper = new ScoreKeeperOnSteroids(consoleWriter);

            //Act
            scoreKeeper.PrintScore();

            //Assert
            consoleWriter.Received(1).PrintResult("000:000");
        }

        [Test]
        public void When_TeamA_Scores_1_Point_Should_Keep_And_Return_Correct_Result()
        {
            var consoleWriter = Substitute.For<IDojoConsole>();
            //Arrange
            var scoreKeeper = new ScoreKeeperOnSteroids(consoleWriter);
            scoreKeeper.ScoreTeamA1();

            //Act
            scoreKeeper.PrintScore();

            //Assert
            consoleWriter.Received(1).PrintResult("001:000");
        }

        [Test]
        public void When_TeamA_Scores_2_Point_Should_Keep_And_Return_Correct_Result()
        {
            var consoleWriter = Substitute.For<IDojoConsole>();
            //Arrange
            var scoreKeeper = new ScoreKeeperOnSteroids(consoleWriter);
            scoreKeeper.ScoreTeamA2();

            //Act
            scoreKeeper.PrintScore();

            //Assert
            consoleWriter.Received(1).PrintResult("002:000");
        }

        [Test]
        public void When_TeamA_Scores_3_Point_Should_Keep_And_Return_Correct_Result()
        {
            var consoleWriter = Substitute.For<IDojoConsole>();
            //Arrange
            var scoreKeeper = new ScoreKeeperOnSteroids(consoleWriter);
            scoreKeeper.ScoreTeamA3();

            //Act
            scoreKeeper.PrintScore();

            //Assert
            consoleWriter.Received(1).PrintResult("003:000");
        }

        [Test]
        public void When_TeamB_Scores_1_Point_Should_Keep_And_Return_Correct_Result()
        {
            var consoleWriter = Substitute.For<IDojoConsole>();
            //Arrange
            var scoreKeeper = new ScoreKeeperOnSteroids(consoleWriter);
            scoreKeeper.ScoreTeamB1();

            //Act
            scoreKeeper.PrintScore();

            //Assert
            consoleWriter.Received(1).PrintResult("000:001");
        }

        [Test]
        public void When_TeamB_Scores_2_Points_Should_Keep_And_Return_Correct_Result()
        {
            var consoleWriter = Substitute.For<IDojoConsole>();
            //Arrange
            var scoreKeeper = new ScoreKeeperOnSteroids(consoleWriter);
            scoreKeeper.ScoreTeamB2();

            //Act
            scoreKeeper.PrintScore();

            //Assert
            consoleWriter.Received(1).PrintResult("000:002");
        }

        [Test]
        public void When_TeamB_Scores_3_Points_Should_Keep_And_Return_Correct_Result()
        {
            var consoleWriter = Substitute.For<IDojoConsole>();
            //Arrange
            var scoreKeeper = new ScoreKeeperOnSteroids(consoleWriter);
            scoreKeeper.ScoreTeamB3();

            //Act
            scoreKeeper.PrintScore();

            //Assert

            consoleWriter.Received(1).PrintResult("000:003");
        }

        [Test]
        public void When_Both_Teams_Score_Multiple_Times_Should_Keep_And_Return_Correct_Result()
        {
            var consoleWriter = Substitute.For<IDojoConsole>();
            //Arrange
            var scoreKeeper = new ScoreKeeperOnSteroids(consoleWriter);
            scoreKeeper.ScoreTeamB3();
            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamA2();

            //Act
            scoreKeeper.PrintScore();

            //Assert
            consoleWriter.Received(1).PrintResult("003:004");
        }
    }
}