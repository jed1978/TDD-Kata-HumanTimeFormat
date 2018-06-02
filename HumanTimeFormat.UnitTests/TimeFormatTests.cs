﻿using NUnit.Framework;
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
    }
}