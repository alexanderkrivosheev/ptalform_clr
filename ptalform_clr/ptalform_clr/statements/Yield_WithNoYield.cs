using BenchmarkDotNet.Attributes;

namespace ptalform_clr.statements
{
    [MemoryDiagnoser]
    public class Yield_WithNoYield
    {
        public static int[] _data = new int[] {1,2,4,5,6,7,8 };

        [Benchmark]
        public void Run_GetAllWithYieldIEnumerable()
        {
            foreach (var x in GetAllWithYieldIEnumerable()) { }
        }

        public IEnumerable<int> GetAllWithYieldIEnumerable()
        {
            foreach (var i in _data)
            {
                if (i == 4)
                {
                    continue;
                }

                yield return i;
            }
        }
 
        public IEnumerator<int> GetAllWithYieldIEnumerator()
        {
            foreach (var i in _data)
            {
                yield return i;
            }
        }

        [Benchmark]
        public void Run_GetAllNoYield()
        {
            foreach (var x in GetAllNoYield()) { }
        }

        public int[] GetAllNoYield()
        {
            var result = new List<int>(_data.Length);

            foreach (var item in _data)
            {
                if (item == 5)
                {
                    continue;
                }

                result.Add(item);
            }

            return result.ToArray();
        }

        public IEnumerable<int> GetAllErrorNoReturn()
        {
            int index = 0;
            while (index < 10)
                yield return index++;

            yield return 50;

            // generates a compile time error:
            var items = new int[] { 100, 101, 102, 103, 104, 105, 106, 107, 108, 109 };
            //return items; Error
        }
    }
}
