using System;
using System.Reflection;
using Quartz;
using log4net;

namespace Orooso.Lib
{
    [DisallowConcurrentExecution]
    public class EpicVideoMonitorJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var e = new OREpicVideoEngine();
            e.EpicVideoMonitor();
        }
    }
}
