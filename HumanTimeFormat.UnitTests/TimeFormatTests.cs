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
        private TimeFormat _timeFormat;

        [SetUp]
        public void SetUp()
        {
            _timeFormat = new TimeFormat();
        }

        [Test]
        public void Test_0_second_Return_now()
        {
            var expected = "now";
            _timeFormat.FormatDuration(0).ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_1_second_Return_1_second()
        {
            var expected = "1 second";
            _timeFormat.FormatDuration(1).ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_2_second_Return_2_seconds()
        {
            var expected = "2 seconds";
            _timeFormat.FormatDuration(2).ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_60_second_Return_1_minute()
        {
            var expected = "1 minute";
            _timeFormat.FormatDuration(60).ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_61_second_Return_1_minute_and_1_second()
        {
            var expected = "1 minute and 1 second";
            _timeFormat.FormatDuration(61).ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_65_second_Return_1_minute_and_5_seconds()
        {
            var expected = "1 minute and 5 seconds";
            _timeFormat.FormatDuration(65).ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_126_second_Return_2_minutes_and_6_seconds()
        {
            var expected = "2 minutes and 6 seconds";
            _timeFormat.FormatDuration(126).ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_3600_second_Return_1_hour()
        {
            var expected = "1 hour";
            _timeFormat.FormatDuration(3600).ShouldBeEqualTo(expected);
        }
    }
}