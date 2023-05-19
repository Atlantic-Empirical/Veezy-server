using Quartz;
using log4net;

namespace Orooso.Lib
{
    [DisallowConcurrentExecution]
    public class YTUpdateJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            ORYouTubeEngine e = new ORYouTubeEngine();
            e.UpdateLiveEvents();
        }
    }
}
