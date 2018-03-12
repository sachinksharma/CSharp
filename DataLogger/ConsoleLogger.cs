using System;

namespace DataLogger
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}