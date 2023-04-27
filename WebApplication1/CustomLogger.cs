using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    public sealed class CustomLogger : ILogger
    {
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => default!;

        public bool IsEnabled(LogLevel logLevel) =>
            true;

        public void Log<TState>(
            LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception? exception,
            Func<TState, Exception?, string> formatter)
        {
            var logObject = state as ILogInfo;
            if (logObject != null)
            {
                Console.WriteLine($"My log info is {logObject.LogInfo.FirstOrDefault().Key}:{logObject.LogInfo.FirstOrDefault().Value}");
            }
            else
            {
                Console.WriteLine("Custom logger massage");
            }
        }
    }
}