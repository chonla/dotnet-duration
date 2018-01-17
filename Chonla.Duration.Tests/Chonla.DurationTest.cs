using System;
using Xunit;

namespace Chonla.Duration.Tests
{
    public class DurationTest
    {
        [Fact]
        public void TestParseMilliseconds()
        {
            var d = new Duration();
            var timespan = d.Parse("20ms");
            Assert.Equal(timespan, TimeSpan.FromMilliseconds(20));
        }

        [Fact]
        public void TestParseNegativeMilliseconds()
        {
            var d = new Duration();
            var timespan = d.Parse("-20ms");
            Assert.Equal(timespan, TimeSpan.FromMilliseconds(-20));
        }

        [Fact]
        public void TestParseSeconds()
        {
            var d = new Duration();
            var timespan = d.Parse("20s");
            Assert.Equal(timespan, TimeSpan.FromSeconds(20));
        }

        [Fact]
        public void TestParseNegativeSeconds()
        {
            var d = new Duration();
            var timespan = d.Parse("-20s");
            Assert.Equal(timespan, TimeSpan.FromSeconds(-20));
        }

        [Fact]
        public void TestParseMinutes()
        {
            var d = new Duration();
            var timespan = d.Parse("20m");
            Assert.Equal(timespan, TimeSpan.FromMinutes(20));
        }

        [Fact]
        public void TestParseNegativeMinutes()
        {
            var d = new Duration();
            var timespan = d.Parse("-20m");
            Assert.Equal(timespan, TimeSpan.FromMinutes(-20));
        }

        [Fact]
        public void TestParseHours()
        {
            var d = new Duration();
            var timespan = d.Parse("20h");
            Assert.Equal(timespan, TimeSpan.FromHours(20));
        }

        [Fact]
        public void TestParseNegativeHours()
        {
            var d = new Duration();
            var timespan = d.Parse("-20h");
            Assert.Equal(timespan, TimeSpan.FromHours(-20));
        }


        [Fact]
        public void TestParseDays()
        {
            var d = new Duration();
            var timespan = d.Parse("20d");
            Assert.Equal(timespan, TimeSpan.FromDays(20));
        }

        [Fact]
        public void TestParseNegativeDays()
        {
            var d = new Duration();
            var timespan = d.Parse("-20d");
            Assert.Equal(timespan, TimeSpan.FromDays(-20));
        }

        [Fact]
        public void TestParseInvalidDurationShouldReturn0TimeSpan()
        {
            var d = new Duration();
            var timespan = d.Parse("Something");
            Assert.Equal(timespan, TimeSpan.FromMilliseconds(0));
        }
    }
}
