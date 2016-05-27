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
    }
}
