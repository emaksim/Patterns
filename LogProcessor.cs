namespace Strategy
{
    //Отвечает за импорт файлов
    public class LogProcessor
    {
        private ILogReader ContextStrategy { get; set; }

        public LogProcessor(ILogReader _context)
        {
            ContextStrategy = _context;
        }

        public string ProcessLogs()
        {
            var lastLog = ContextStrategy.GetLastLog();
            return lastLog?.Message ?? "";
        }
    }
}