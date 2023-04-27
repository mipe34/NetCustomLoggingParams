using Microsoft.Extensions.Logging;
namespace WebApplication1
{
    [ProviderAlias("ColorConsole")]
    public sealed class CustomLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new CustomLogger();
        }

        public void Dispose()
        {

        }
    }
}