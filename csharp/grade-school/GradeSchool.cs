using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class GradeSchool
{
    private SortedList<string, int> Students { get; set; }
    private int MaxGrade { get; set; }

    public GradeSchool()
    {
        Students = new SortedList<string, int>();
        MaxGrade = 0;
    }
    public void Add(string student, int grade)
    {
        try
        {
            Students.Add(student, grade);
            if (grade > MaxGrade)
            {
                MaxGrade = grade;
            }

        }
        catch (ArgumentException)
        {
            Console.WriteLine("Key " + student + " already exists");
        }
    }
    
    public IEnumerable<string> Roster()
    {

        int grade = 1;
        while (grade <= MaxGrade)
        {
            foreach (string name in Grade(grade))
            {
                yield return name;
            }
            grade++;
        }
    }

    public IEnumerable<string> Grade(int grade)
    {
        foreach (KeyValuePair<string, int> student in Students)
        {
            if (student.Value == grade)
            {
                yield return student.Key;
            }
        }
    }
}