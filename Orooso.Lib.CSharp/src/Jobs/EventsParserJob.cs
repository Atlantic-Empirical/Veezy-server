using System;
using System.Reflection;
using Quartz;
using log4net;

namespace Orooso.Lib
{
    [DisallowConcurrentExecution]
    public class EventsParserJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var e = new ORStatsEngine();
            e.ParseEvents();
        }
    }
}
