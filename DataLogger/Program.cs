using System;

namespace DataLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var migrator = new DataMigrator(new ConsoleLogger());
            migrator.Migrate();
            Console.ReadLine();
        }
    }
}
