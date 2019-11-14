using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    public SortedList<string, int> Students { get; set; }

    public GradeSchool()
    {
        Students = new SortedList<string, int>();
    }
    public void Add(string student, int grade)
    {
        try
        {
            Students.Add(student, grade);
        } catch(ArgumentException)
        {
            Console.WriteLine("Key " + student + " already exists");
        }
    }

    
    public IEnumerable<string> Roster()
    {
        List<string> studentsList = new List<string>() { };

        foreach (KeyValuePair<string, int> student in Students)
        {
            studentsList.Add(student.Key);
        }

        return studentsList.ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        List<string> studentsList = new List<string>() { };

        foreach (KeyValuePair<string, int> student in Students)
        {
            if (student.Value==grade) studentsList.Add(student.Key);
        }

        studentsList.Sort();
        return studentsList.ToArray();
    }
}