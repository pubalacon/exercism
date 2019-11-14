using System;
using System.Collections.Generic;

public class Robot
{
    private static List<string> names = new List<string>();

    public string Name { get; set; }

    public Robot()
    {
        string newName = "";
        
        do
        {
            newName = RandomString(1, 2) + RandomString(2, 3);
            Console.WriteLine(newName);
        } while (newName=="" || nameExists(newName));

        names.Add(newName); // on ajoute le nouveau nom a names

        Name = newName; // set
    }
    public bool nameExists(string newName)
    {
        return names.Contains(newName);
    }

    public string RandomString(int type, int len)
    {
        var chars1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var chars2 = "0123456789";
        var temp = new char[len];

        var random = new Random();

        for (int i = 0; i < len; i++)
        {
            if (type == 1) temp[i] = chars1[random.Next(chars1.Length)];
            if (type == 2) temp[i] = chars2[random.Next(chars2.Length)];
        }

        return temp.ToString();
    }

    public void Reset()
    {
        string newName = "";
        do
        {
            newName = RandomString(1, 2) + RandomString(2, 3);
        } while (nameExists(newName));

        names.Add(newName); // on ajoute le nouveau nom a names

        Name = newName; // set
    }
}