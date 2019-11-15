using System;
using System.Collections.Generic;

// https://www.kenneth-truyers.net/2016/05/12/yield-return-in-c/

public class Tools
{
    public static IEnumerable<int> makeEnum(int start, int end)
    {
        while (start < end)
        {
            yield return start;
            start++;
        }
    }

    public void getList()
    {
        foreach (int x in makeEnum(1, 10))
        {
            Console.WriteLine(x);
        }
    }

}