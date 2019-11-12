using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    /*
	public static string Speak(string Name="")
    {
        if (Name == "")
        {
            return "One for you, one for me.";
        }
        else
        {
            return "One for "+Name+", one for me.";
        }
    }
	*/
	
	// overloading
	public static string Speak()
    {
        return "One for you, one for me.";
	}
	public static string Speak(String Name)
    {
        return "One for "+Name+", one for me.";
	}
}
