using NLog;

namespace BlogApp.Business.Tools.LogTool
{
    public class NLogAdapter : ICustomLogger
    {
        public void LogError(string message)
        {
            var logger = LogManager.GetLogger("fileLogger");
            logger.Log(LogLevel.Error, message);
        }
    }
}
