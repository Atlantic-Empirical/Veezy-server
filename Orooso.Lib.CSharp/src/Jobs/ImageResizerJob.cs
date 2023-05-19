using System.Reflection;
using Quartz;
using log4net;

namespace Orooso.Lib
{
    [DisallowConcurrentExecution]
    public class ImageResizerJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            ORMediaEngine engine = new ORMediaEngine();
            engine.ParseQueue();
        }
    }
}
