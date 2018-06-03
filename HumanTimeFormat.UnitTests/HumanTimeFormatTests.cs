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
    }
}
