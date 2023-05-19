using Quartz;
using log4net;

namespace Orooso.Lib
{
    [DisallowConcurrentExecution]
    public class ImageCacheCleanupJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            ORBingEngine e = new ORBingEngine();
            e.ImageCacheCleanup();
        }
    }
}
