using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy.LogTypes
{
	public class WindowsEventLogReader : ILogReader
	{
		public LogEntry GetLastLog(List<LogEntry> list)
		{
			if (list == null)
			{
				list = Read();
			}
			return list.LastOrDefault();
		}

		public List<LogEntry> Read()
		{
			throw new NotImplementedException();
		}
	}
}