namespace Jason.Test;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jason.Algorithm;
using System.Reflection.Metadata;

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
        CollectionAssert.AreEqual(new List<bool>([true, false, false, false, false]), sa.KidsWithCandies([4, 2, 1, 1, 2], 1).ToList());
        CollectionAssert.AreEqual(new List<bool>([true, false, true]), sa.KidsWithCandies([12, 1, 12], 10).ToList());
    }


    [TestMethod]
    public void TC_443()
    {
        StringAlgorithm sa = new StringAlgorithm();

        char[] chars = "aabbccc".ToCharArray();

        Assert.AreEqual(6, sa.Compress(chars));
        Assert.AreEqual("a2b2c3", new string(chars).Substring(0, 6));

        chars = "a".ToCharArray();
        Assert.AreEqual(1, sa.Compress(chars));
        Assert.AreEqual("a", new string(chars).Substring(0, 1));

        chars = "abbbbbbbbbbbb".ToCharArray();
        Assert.AreEqual(4, sa.Compress(chars));
        Assert.AreEqual("ab12", new string(chars).Substring(0, 4));


    }


    [TestMethod]
    public void TC_8000()
    {
        StringAlgorithm sa = new StringAlgorithm();
        Assert.IsFalse(sa.IsPalindrome("Never Odd Or Even", false, false));
        Assert.IsFalse(sa.IsPalindrome(null));
        Assert.IsTrue(sa.IsPalindrome("a"));
        Assert.IsTrue(sa.IsPalindrome("aa"));
        Assert.IsTrue(sa.IsPalindrome("abcba"));
        Assert.IsFalse(sa.IsPalindrome("abcd"));
        Assert.IsTrue(sa.IsPalindrome("Mr owl ate my metal worm"));
        Assert.IsTrue(sa.IsPalindrome("Never Odd Or Even"));
        Assert.IsFalse(sa.IsPalindrome("Never Even Or Odd"));
        Assert.IsTrue(sa.IsPalindrome("中文文中"));
        Assert.IsFalse(sa.IsPalindrome("&'(@.@)'&"));

    }
}
