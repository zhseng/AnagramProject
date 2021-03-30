using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Anagram;

namespace AnagramTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StraightTest1()
        {
            string input = "car", sample = "race";
            AnagramTool obj = new AnagramTool();

            Assert.AreEqual<bool>(true, obj.AnagramStrStr(input, sample));
        }

        [TestMethod]
        public void StraightTest2()
        {
            string input = "nod", sample = "done";
            AnagramTool obj = new AnagramTool();

            Assert.AreEqual<bool>(true, obj.AnagramStrStr(input, sample));
        }

        [TestMethod]
        public void StraightTest3()
        {
            string input = "bag", sample = "grad";
            AnagramTool obj = new AnagramTool();

            Assert.AreEqual<bool>(false, obj.AnagramStrStr(input, sample));
        }
    }
}
