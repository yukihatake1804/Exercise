using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CeilFloor()
        {
            int result1 = Program.Ceil((float)2.3);
            Assert.AreEqual(3, result1);

            int result2 = Program.Ceil((float)-2.3);
            Assert.AreEqual(-2, result2);

            int result5 = Program.Ceil((float)3);
            Assert.AreEqual(3, result5);

            int result6 = Program.Floor((float)3);
            Assert.AreEqual(3, result6);

            int result3 = Program.Floor((float)2.3);
            Assert.AreEqual(2, result3);

            int result4 = Program.Floor((float)-2.3);
            Assert.AreEqual(-3, result4);

        }

    }
}
