using System;
using System.Threading;
using System.Threading.Tasks;

namespace  ParallelTasksAsync
{
    internal class BusinessLayer
    {        
        public static void PrepareTask1(Action<string> updateUICallBack)
        {
            Task.Factory.StartNew(
              () =>
              {
                  for (int i = 0; i <= 100; i++)
                  {
                      Thread.Sleep(50); //simulateWork, do something with the data received
                      updateUICallBack(string.Format("Processing Task 1 {0}% done", i));
                  }
                  updateUICallBack("Processing Task 1 100% complete");
              }).Wait();
        }

        public static void PrepareTask2(Action<string> updateUICallBack)
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

        public static void PrepareTask3( Action<string> updateUICallBack)
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
