/*

One might think that, since a DateTime variable can never be null (it is automatically initialized to Jan 1, 0001), the compiler would complain when a DateTime variable is compared to null. However, due to type coercion, the compiler does allow it, which can potentially lead to headfakes and pull-out-your-hair bugs.
Specifically, the == operator will cast its operands to different allowable types in order to get a common type on both sides, which it can then compare. That is why something like this will give you the result you expect (as opposed to failing or behaving unexpectedly because the operands are of different types):

double x = 5.0;
int y = 5;
Console.WriteLine(x == y);  // outputs true
However, this can sometimes result in unexpected behavior, as is the case with the comparison of a DateTime variable and null. In such a case, both the DateTime variable and the null literal can be cast to Nullable<DateTime>. Therefore it is legal to compare the two values, even though the result will always be false.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ptalform_clr.statement_if
{
    public class Task1
    {
        private String location;
        private DateTime time;

        [Fact]
        public void If_Struct_Null_False()
        {            
            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(5 == null ? "time is null" : time.ToString());
        }

    }
}
