using System;

namespace Strategy
{
    public class LogEntry
    {
        public DateTime DateTime { get; set; }
        public bool Severity { get; set; }
        public string Message { get; set; }

    }
}