using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Strategy.LogTypes
{
    public class LogFileReader : ILogReader
    {
        List<LogEntry> LogEntries;
        public LogEntry GetLastLog(List<LogEntry> list = null)
        {
            if (list == null)
            {
                list = Read();
            }
            return list.LastOrDefault();
        }

        public List<LogEntry> Read()
        {
            LogEntries = new List<LogEntry>();
            string[] lines = File.ReadAllLines(@"C:\Users\Maxim\source\repos\Patterns\log.txt");
            foreach (string textFromFile in lines)
            {
                LogEntry entry = new LogEntry { DateTime = System.DateTime.Now, Severity = textFromFile.Length > 60, Message = textFromFile };
                LogEntries.Add(entry);
            }

            return LogEntries;
        }
    }
}