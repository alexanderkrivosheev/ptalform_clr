using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ptalform_clr.await_async
{
    public class Task1
    {
        private string _result;

        public async void Main()
        {
            var result = SaySomething();
            Console.WriteLine(_result);
        }
        public async Task<string> SaySomething()
        {
            await Task.Delay(500);
            _result = "Hello world!";
            return "Something";
        }

        #region Solution

        public void Main1()
        {
            var result = SaySomething().GetAwaiter().GetResult();
            Console.WriteLine(_result);
        }

        #endregion

    }
}
