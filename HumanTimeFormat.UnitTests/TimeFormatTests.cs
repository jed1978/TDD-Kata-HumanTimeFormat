using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;

namespace HumanTimeFormat.UnitTests
{
    [TestFixture]
    public class TimeFormatTests
    {
        [Test]
        public void Test_0_second_Return_now()
        {
            var expected = "now";
            var timeFormat = new TimeFormat();
            var actual = timeFormat.FormatDuration(0);
            actual.ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_1_second_Return_1_second()
        {
            var expected = "1 second";
            var timeFormat = new TimeFormat();
            var actual = timeFormat.FormatDuration(1);
            actual.ShouldBeEqualTo(expected);
        }
    }
}