using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jason.Algorithm;

namespace Test
{
    [TestClass]
    public class UTString
    {
        [TestMethod]
        public void TC_1071()
        {
            StringAlgorithm sa = new StringAlgorithm();

            Assert.AreEqual("ABC", sa.GcdOfStrings("ABCABC", "ABC"));
            Assert.AreEqual("AB", sa.GcdOfStrings("ABABAB", "ABAB"));
            Assert.AreEqual("", sa.GcdOfStrings("LEET", "CODE"));
            Assert.AreEqual("NLZGM", sa.GcdOfStrings("NLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGM", "NLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGM"));
        }

        [TestMethod]
        public void TC_1768()
        {
            StringAlgorithm sa = new StringAlgorithm();

            Assert.AreEqual("a1b2c3", sa.MergeAlternately1("abc", "123"));
            Assert.AreEqual("a1b234", sa.MergeAlternately1("ab", "1234"));
            Assert.AreEqual("a1b2cd", sa.MergeAlternately1("abcd", "12"));
            Assert.IsTrue(sa.MergeAlternately1("", "12").Contains("Exception"));
        }
    }
}