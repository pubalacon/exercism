using System;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private Allergen Mask { get; set; }

    public Allergies(int mask)
    {
        Mask = (Allergen)mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        
    }

    public Allergen[] List()
    {
        
    }
}