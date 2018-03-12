using System;

namespace DataLogger
{
    public class DataMigrator
    {
        private readonly ILogger _logger;

        public DataMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            _logger.LogInfo("Migration completed at " + DateTime.Now);
        }


    }
}