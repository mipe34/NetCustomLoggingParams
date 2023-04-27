using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
  
    public static class ColorConsoleLoggerExtensions
    {
        public static ILoggingBuilder AddCustomLogger(
            this ILoggingBuilder builder)
        {
            builder.AddConfiguration();

            builder.Services.TryAddEnumerable(
                ServiceDescriptor.Singleton<ILoggerProvider, CustomLoggerProvider>());
            return builder;
        }

        public static void LogInformation(this ILogger logger, string message, ILogInfo logInfo) 
        {
            logger.Log(LogLevel.Information, 0, logInfo, default, (lo, e) => $"Funkce, ktera udela z logInfo id {logInfo?.LogInfo.FirstOrDefault().Key} : {logInfo?.LogInfo.FirstOrDefault().Value}, message: {message} a exception (pokud prijde) nejaky string");
        }
        
    }
}
