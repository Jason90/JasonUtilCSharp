namespace Jason.Algorithm;

using System.Text;

public class StringAlgorithm
{

    #region 1071. Greatest Common Divisor of Strings
    public string GcdOfStrings(string str1, string str2)
    {
        return str1.Length > str2.Length ? GcdStrings(str1, str2) : GcdStrings(str2, str1);
    }

    private string GcdStrings(string str1, string str2)
    {
        if (IsGCDString(str1, str2))
            return str2;
        else
        {
            for (int i = str2.Length / 2; i > 0; i--)
            {
                String sub = str2.Substring(0, i);
                if (IsGCDString(str2, sub) && IsGCDString(str1, sub))
                    return sub;
            }
        }
        return ""; //Not GCD strings
    }
    private Boolean IsGCDString(string word, string divide)
    {
        if (word.Length % divide.Length == 0)
        {
            int i = 0;
            int loop = word.Length / divide.Length;
            do
            {
                if (divide.CompareTo(word.Substring(i * divide.Length, divide.Length)) != 0)
                    return false;
                i++;
            } while (i < loop);
        }
        else
        {
            return false;
        }
        return true;
    }
    #endregion 1071


    #region 1768. Merge Strings Alternately

    public string MergeAlternately1(string word1, string word2)
    {
        if (word1.Length < 1 || word2.Length < 1 || word1.Length > 100 || word2.Length > 100)
        {
            return "Exception: 1 <= word1.Length, word2.Length <= 100";
            // throw new Exception("1 <= word1.Length, word2.Length <= 100");
        }
        StringBuilder sb = new StringBuilder();

        int min = Math.Min(word1.Length, word2.Length);

        for (int i = 0; i < min; i++)
        {
            word1 = word1.Insert(2 * i + 1, word2[i].ToString());
        }

        if (word2.Length > min)
        {
            word1 = word1.Insert(2 * min, word2.Substring(min));
        }

        return word1;
    }
    public string MergeAlternately2(string word1, string word2)
    {
        if (word1.Length < 1 || word2.Length < 1 || word1.Length > 100 || word2.Length > 100)
        {
            throw new Exception("1 <= word1.Length, word2.Length <= 100");
        }
        StringBuilder sb = new StringBuilder();

        int min = Math.Min(word1.Length, word2.Length);

        for (int i = 0; i < min; i++)
        {
            if (i < word1.Length)
                sb.Append(word1[i]);
            if (i < word2.Length)
                sb.Append(word2[i]);
        }


        return sb.ToString();
    }
    public string MergeAlternately3(string word1, string word2)
    {
        if (word1.Length < 1 || word2.Length < 1 || word1.Length > 100 || word2.Length > 100)
        {
            throw new Exception("1 <= word1.Length, word2.Length <= 100");
        }
        StringBuilder sb = new StringBuilder();

        int min = Math.Min(word1.Length, word2.Length);

        for (int i = 0; i < min; i++)
        {
            sb.Append(word1[i]);
            sb.Append(word2[i]);
        }

        if (word1.Length < word2.Length)
            sb.Append(word2.Substring(min));
        else if (word1.Length > word2.Length)
            sb.Append(word1.Substring(min));

        return sb.ToString();
    }
    #endregion 1768

    #region 1431. Kids With the Greatest Number of Candies
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        //Step1: Find max num
        int max = 0;
        foreach (int candie in candies)
        {
            if (candie > max)
            {
                max = candie;
            }
        }
        //Step2: Find num>=max-extra 
        IList<bool> results = new List<bool>();
        int cutoff = max - extraCandies;
        foreach (int candie in candies)
        {
            if (candie >= cutoff)
            {
                results.Add(true);
            }
            else
            {
                results.Add(false);
            }
        }

        return results;
    }

    public IList<bool> KidsWithCandies1(int[] candies, int extraCandies)
    {
        //Step1: Find max num
        int max = 0;
        foreach (int candie in candies)
        {
            if (candie > max)
            {
                max = candie;
            }
        }
        //Step2: Find num>=max-extra 
        IList<bool> results = new List<bool>();
        int cutoff = max - extraCandies;
        foreach (int candie in candies)
        {
            if (candie >= cutoff)
            {
                results.Add(true);
            }
            else
            {
                results.Add(false);
            }
        }

        return results;
    }
    #endregion  1431
}
