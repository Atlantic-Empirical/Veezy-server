using Quartz;
using log4net;

namespace Orooso.Lib
{
    [DisallowConcurrentExecution]
    public class DDBBackupJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            ORBackupEngine e = new ORBackupEngine();
            e.BackupAllTables();
        }
    }
}
