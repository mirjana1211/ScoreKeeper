using System;

namespace ScoreKeeper
{
    public class DojoConsole : IDojoConsole
    {
        public void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}