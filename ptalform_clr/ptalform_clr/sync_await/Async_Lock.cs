using BenchmarkDotNet.Attributes;

namespace ptalform_clr.statements
{
    [MemoryDiagnoser]
    public class Async_Lock
    {
        private static readonly object _lock = new object();

        public async Task ExampleMethodAsync()
        {
            lock (_lock)
            {
                // Your asynchronous code here
                //await SomeAsyncOperation();
            }
        }

        public async Task SomeAsyncOperation()
        {
            await Task.Delay(5000);
        }

        private static readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        public async Task ExampleMethodAsync2()
        {
            await semaphore.WaitAsync();
            try
            {
                // Your asynchronous code here
                await SomeAsyncOperation();
            }
            finally
            {
                semaphore.Release();
            }
        }

    }
}
