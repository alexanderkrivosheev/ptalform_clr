using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptalform_clr.operators
{
    internal class implicit_converter_type
    {
        public static IEnumerable<Result<int>> GetResults()
        {
            yield return new Result<int>(0);

            yield return 2;
        }
    }

    public class Result<TValue>
    {
        private readonly TValue result;

        public Result(TValue result)
        {
            this.result = result;
        }

        public static implicit operator Result<TValue>(TValue result) 
        {
            return new Result<TValue>(result);
        }
    }       
}
