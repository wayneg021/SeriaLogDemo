using System;
using Serilog;
using Serilog.Core;

namespace LogManager
{
    public class LogManager : ILogManager
    {
        private readonly Logger _logger;

        protected static Logger DefaultLogger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        internal LogManager(Logger logger)
        {
            _logger = logger ?? DefaultLogger;
        }

        public LogManager()
            : this(null)
        { }

        public void LogInfo(string message)
        {
            _logger.Information(message);
        }
    }
}
