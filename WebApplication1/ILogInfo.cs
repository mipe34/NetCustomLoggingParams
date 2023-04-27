using System.Collections.Generic;

namespace WebApplication1
{
    public interface ILogInfo
    {
        IEnumerable<KeyValuePair<string, object>> LogInfo { get; }
    }
}
