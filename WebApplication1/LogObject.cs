using System.Collections.Generic;

namespace WebApplication1
{
    // Token
    public class LoggObject : ILogInfo
    {
        public string Id { get; set; }

        public IEnumerable<KeyValuePair<string, object>> LogInfo
        {
            get
            {
                yield return new KeyValuePair<string, object>(nameof(Id), Id);
            }
        }
    }
}
