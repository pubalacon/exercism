using System;
using System.Collections.Generic;

public static class RotationalCipher
{
    private static string Plain = "abcdefghijklmnopqrstuvwxyz";
    private static string Cipher = "abcdefghijklmnopqrstuvwxyz";

    public static string getRotated(string s)
    {
        return Cipher.Substring(Plain.IndexOf(s), 1);
    }

    public static string toLowerCase(char c)
    {
        return c.ToString().ToLower();
    }

    public static string Rotate(string text, int shiftKey)
    {
        if (shiftKey >= 26) shiftKey = shiftKey - 26;

        Cipher = Plain.Substring(shiftKey) + Plain.Substring(0, shiftKey);
        
        string[] AText;
        AText = new[] { text };

        string Rotated = "";
        string RotatedChar = "";

        for (int i =0; i<text.Length; i++)
        {
            string toFind = toLowerCase(text[i]);
            if (Plain.Contains(toFind))
            {
                RotatedChar = getRotated(toFind);
            }
            else
            {
                RotatedChar = toFind;
            }

            RotatedChar = char.IsUpper(text[i]) ? RotatedChar.ToUpper() : RotatedChar;

            Rotated += RotatedChar;
        }

        return Rotated;
    }
}