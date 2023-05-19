using Quartz;
using log4net;

namespace Orooso.Lib
{
    [DisallowConcurrentExecution]
    public class TVNZParserJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            ORTVNZEngine e = new ORTVNZEngine();
            e.ParseAllFeeds();
        }
    }
}
