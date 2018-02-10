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

        public void LogFatal(Exception ex, string message)
        {
            _logger.Fatal(ex, message);
        }

        public void LogError(string error)
        {
            _logger.Error(error);
        }
    }
}
