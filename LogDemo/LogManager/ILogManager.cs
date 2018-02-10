using System;
using System.Collections.Generic;
using System.Text;

namespace LogManager
{
    public interface ILogManager
    {
        void LogInfo(string message);

        void LogFatal(Exception ex, string message);

        void LogError(string error);
    }
}
