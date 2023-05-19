using System;
using System.Reflection;
using Quartz;
using log4net;

namespace Orooso.Lib
{
    [DisallowConcurrentExecution]
    public class EpicDailyDigestJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var e = new OREpicUserEngine();
            e.SendDailyDigests();
        }
    }
}
