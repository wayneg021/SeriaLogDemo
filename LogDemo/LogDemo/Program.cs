using System;
using LogManager;

namespace LogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogManager logManager = new LogManager.LogManager();
            logManager.LogInfo("Hello Seri!");
            logManager.LogError("Test Error");
            logManager.LogInfo("One more");

            Console.ReadLine();
        }
    }
}
