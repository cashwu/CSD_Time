using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Time.Test
{
    [TestClass]
    public class TimeTest
    {
        [TestMethod]
        public void GetNowStringTest()
        {
            var dt = DateTime.Now;
            var t = new Time(dt);
            var result = t.GetNowString();

            var expect = dt.ToString("yyyy/MM/dd HH:mm:ss fff");

            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void GetNowStringTest2()
        {
            var t = new Time(new SubDateTime());
            var result = t.GetNowString();

            var expect = "2016/05/27 13:50:10 100";

            Assert.AreEqual(expect, result);
        }
    }

    class SubDateTime : IDateTime
    {
        public DateTime GetDate()
        {
            return new DateTime(2016, 5, 27, 13, 50, 10, 100);
        }
    }
}
