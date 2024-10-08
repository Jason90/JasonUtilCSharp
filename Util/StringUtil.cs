namespace Jason.Util;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



/// <summary>
/// Extend Sting class
/// </summary>
public static class StringUtil
{
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }
}
