using Strategy.LogTypes;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var logFileReader = new LogFileReader();
            var windowsEventLogReader = new WindowsEventLogReader();

            var logFileReaderProcessor = new LogProcessor(logFileReader);
            var windowsEventLogReaderProcessor = new LogProcessor(windowsEventLogReader);

            Console.WriteLine("Last message from LogFileReader : " + logFileReaderProcessor.ProcessLogs());
            Console.WriteLine("Last message from WindowsEventLogReader : " + windowsEventLogReaderProcessor.ProcessLogs());
        }
    }
}