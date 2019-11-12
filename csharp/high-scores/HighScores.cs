using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> list;

    public HighScores(List<int> list)
    {
        this.list = list;
    }

    public List<int> Scores()
    {
        return this.list;
    }

    public int Latest()
    {
        return this.Scores().Last();
    }

    public int PersonalBest()
    {
        this.Scores().Sort((a, b) => -1 * a.CompareTo(b)); // tri les int sur ordre descendant
        return this.Scores()[0];
    }

    public List<int> PersonalTopThree()
    {
        List<int> temp = new List<int>();
        int j = 3;

        this.Scores().Sort((a, b) => -1 * a.CompareTo(b)); // tri les int sur ordre descendant

        if (this.Scores().Count() < j) j = this.Scores().Count();

        for (int i=0; i<j; i++)
        {
            temp.Add(this.Scores()[i]);
        }
        return temp;
    }
}