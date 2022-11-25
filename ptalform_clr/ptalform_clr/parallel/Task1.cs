using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ptalform_clr.parallel
{
    public class Task1
    {
        int iteraion = 1000;
        private static object _lock =new object();

        public void Main()
        {
            Parallel_Iteration_NotEqual();
            Parallel_Iteration_Interlocked_Equal();
            Parallel_Iteration_Volatile_Equal();
        }

        [Fact]
        public void Parallel_Iteration_NotEqual()
        {
            int count = 0;
            Parallel.For(0, iteraion, (_) => count++);
            Console.WriteLine($"count:{count} iteraion:{iteraion}");            
        }

        #region Solutions

        [Fact]
        public void Parallel_Iteration_Interlocked_Equal()
        {
            int count = 0;
            Parallel.For(0, iteraion, (_) => Interlocked.Increment(ref count));
            Console.WriteLine($"count:{count} iteraion:{iteraion}");
        }

        [Fact]
        public void Parallel_Iteration_Volatile_Equal()
        {
            int count = 0;
            Parallel.For(0, iteraion, (_) => {
                lock (_lock)
                {
                    count++;
                }
            });
            Console.WriteLine($"count:{count} iteraion:{iteraion}");
        }
      
        #endregion
    }
}
