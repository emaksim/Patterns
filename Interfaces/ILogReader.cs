using System.Collections.Generic;

namespace Strategy
{
    public interface ILogReader
    {
        List<LogEntry> Read();
        LogEntry GetLastLog(List<LogEntry> list = null);
    }
}