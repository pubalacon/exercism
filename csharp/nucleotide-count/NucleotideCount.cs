using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static Dictionary<char, int> acgt = new Dictionary<char, int>()
    {
        { Convert.ToChar("A"), 0 },
        { Convert.ToChar("C"), 0 },
        { Convert.ToChar("G"), 0 },
        { Convert.ToChar("T"), 0 }
    };

    public static IDictionary<char, int> Count(string sequence)
    {
        sequence = sequence.ToUpper();

        if (acgt.TryGetValue(Convert.ToChar("A"), out int val))
        {
            acgt['A'] = 0; acgt['C'] = 0; acgt['G'] = 0; acgt['T'] = 0;
        }

        for (int i=0; i<sequence.Length; i++)
        {
            if (sequence[i]== 'A' || sequence[i] == 'C' || sequence[i] == 'G' || sequence[i] == 'T')
            {
                acgt[sequence[i]] += 1;
            }
            else
            {
                throw new System.ArgumentException("Nucleotide " + sequence[i] + " at position " + i + "doesn't seem to be valid");
            }
        }

        return acgt;
    }
}

