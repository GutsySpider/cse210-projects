using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Tony Tiger", "Spanish");
        Console.WriteLine(a1.GetSummary());

        MathAssignment ma1 = new MathAssignment("Michael Bowman", "Math", "Section 7.3", "Problems 8-19");
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeworkList());
        
        WritingAssignment w1 = new WritingAssignment("George Lucas", "WWII", "Militia Weapons");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}