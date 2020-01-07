namespace  ParallelTasksAsync
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    public class BusinessLayer
    {        
        public void PrepareTask1(Action<string> updateUICallBack)
        {
            var task = new Task(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(500); //simulateWork, do something with the data received
                    updateUICallBack(string.Format("Processing Task 1 {0}% done", i));
                }
                updateUICallBack("Processing Task 1 100% complete");
            });
            task.Start();
        }

        public void PrepareTask2(Action<string> updateUICallBack)
        {
            Task.Factory.StartNew(
              () =>
              {
                  for (int i = 0; i <= 100; i++)
                  {
                      Thread.Sleep(50); //simulateWork, do something with the data received
                      updateUICallBack(string.Format("Processing Task 2 {0}% done", i));
                  }
                  updateUICallBack("Processing Task 2 100% complete");
              }).Wait();
        }

        public  void PrepareTask3( Action<string> updateUICallBack)
        {
            Task.Factory.StartNew(
              () =>
              {
                  for (int i = 0; i <= 100; i++)
                  {
                      Thread.Sleep(50); //simulateWork, do something with the data received
                        updateUICallBack(string.Format("Processing Task 3 {0}% done", i));
                  }
                  updateUICallBack("Processing Task 3 100% complete");
              }).Wait();
            
        }
    }
}
