using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;

namespace HumanTimeFormat.UnitTests
{
    [TestFixture]
    public class HumanTimeFormatTests
    {
        private TimeFormat _humanTimeFormat;

        private void ShouldBe(int duration, string expected)
        {
            _humanTimeFormat.FormatDuration(duration).ShouldBeEqualTo(expected);
        }

        [SetUp]
        public void SetUp()
        {
            _humanTimeFormat = new TimeFormat();
        }

        [Test]
        public void Test_0_Return_now()
        {
            var expected = "now";
            ShouldBe(0, expected);
        }

        [Test]
        public void Test_1_Return_1_second()
        {
            var expected = "1 second";
            ShouldBe(1, expected);
        }

        [Test]
        public void Test_2_Return_2_seconds()
        {
            var expected = "2 seconds";
            ShouldBe(2, expected);
        }

        [Test]
        public void Test_60_Return_1_minute()
        {
            var expected = "1 minute";
            ShouldBe(60, expected);
        }

        [Test]
        public void Test_122_Return_2_minutes_and_2_seconds()
        {
            var expected = "2 minutes and 2 seconds";
            ShouldBe(122, expected);
        }

        [Test]
        public void Test_3600_Return_1_hour()
        {
            var expected = "1 hour";
            ShouldBe(3600, expected);
        }

        [Test]
        public void Test_7202_Return_2_hours_and_2_seconds()
        {
            var expected = "2 hours and 2 seconds";
            ShouldBe(7202, expected);
        }

        [Test]
        public void Test_172921_Return_2_days_2_minutes_and_1_second()
        {
            var expected = "2 days, 2 minutes and 1 second";
            ShouldBe(172921, expected);
        }

        [Test]
        public void Test_31536000_Return_1_year()
        {
            var expected = "1 year";
            ShouldBe(31536000, expected);
        }

        [Test]
        public void Test_31536121_Return_1_year_2_minutes_and_1_second()
        {
            var expected = "1 year, 2 minutes and 1 second";
            ShouldBe(31536121, expected);
        }

        [Test]
        public void Test_101956166_Return_3_years_85_days_1_hour_9_minutes_and_26_seconds()
        {
            var expected = "3 years, 85 days, 1 hour, 9 minutes and 26 seconds";
            ShouldBe(101956166, expected);
        }
    }
}