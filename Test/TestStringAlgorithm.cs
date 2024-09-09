namespace Jason.Test;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jason.Algorithm;


[TestClass]
public class TestStringAlgorithm
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

    [TestMethod]
    public void TC_1431()
    {
        StringAlgorithm sa = new StringAlgorithm();

        CollectionAssert.AreEqual(new List<bool>([true, true, true, false, true]), sa.KidsWithCandies([2, 3, 5, 1, 3], 3).ToList());
        CollectionAssert.AreEqual(new List<bool>([true,false,false,false,false]), sa.KidsWithCandies([4,2,1,1,2], 1).ToList());
        CollectionAssert.AreEqual(new List<bool>([true,false,true]), sa.KidsWithCandies([12,1,12], 10).ToList());
    }
}
