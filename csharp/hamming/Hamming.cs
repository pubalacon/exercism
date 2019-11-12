using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int distance = 0;

        if (firstStrand.Length == 0 && secondStrand.Length == 0) return 0;

        if (firstStrand.Length != secondStrand.Length)
        {
            throw new System.ArgumentException("The strings to compare MUST have the same length");
        }
        else { 

            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i]) distance++;
            }
        }
        return distance;
    }
}