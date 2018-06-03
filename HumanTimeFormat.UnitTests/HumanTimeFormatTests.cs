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
        [Test]
        public void Test_0_Return_now()
        {
            var expected = "now";
            var humanTimeFormat = new TimeFormat();
            var actual = humanTimeFormat.FormatDuration(0);
            actual.ShouldBeEqualTo(expected);
        }

        
    }
}
