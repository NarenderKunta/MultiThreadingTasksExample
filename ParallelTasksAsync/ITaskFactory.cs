using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelTasksAsync
{
    public interface ITaskFactory
    {
        void StartTask(Action action);
    }
}
