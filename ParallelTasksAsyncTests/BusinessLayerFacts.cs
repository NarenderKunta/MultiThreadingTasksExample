namespace ParallelTasksAsyncTests
{
    using System.Threading.Tasks;
    using ParallelTasksAsync;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading;
    using System.Diagnostics;
    using Shouldly;

    [TestClass]
    public class BusinessLayerFacts
    {

        [TestMethod]
        public void PrepareTask1_Always_DoProcess()
        {
            // Arrange
            var fixture = this.CreateFixute();

            // Act
            fixture.PrepareTask1((x) => UpdateProgressBar1(x));

            // Assert
            fixture.ShouldNotBeNull();
            
        }

        private BusinessLayer CreateFixute()
        {
            var fixture = new BusinessLayer();
            return fixture;
        }
        private void UpdateProgressBar1(string statusMessage)
        {
            Task.Factory.StartNew(() =>
            {
                Trace.WriteLine(statusMessage);
            }, CancellationToken.None, TaskCreationOptions.None,null);
        }
    }
}
