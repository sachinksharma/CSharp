using System.IO;

namespace DataLogger
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "Error");
        }

        public void LogInfo(string message)
        {
            Log(message, "Info");
        }

        public void Log(string message, string messageType)
        {
            using (StreamWriter sw = new StreamWriter(_path, true))
            {
                sw.WriteLine(messageType + " : " + message);
            }
        }
    }
}