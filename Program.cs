using System;

namespace UnderstandingTuples
{    
    class Program
    {
        static void Main()
        {
            FirstLookAtTuples();
            UseSpecificNamesAtTuples();
            UseNestedTuples();
            UsedTuplesAsMethodReturnValues();
            UseDeconstructingTuples();

            Console.ReadLine();
        }

        // Tuples are lightweight data structures that contain multiple fields.
        // These are two important considerations for tuples:
        // • The fields are not validated.
        // • You cannot define your own methods.
        // They are really designed to just be a lightweight data transport mechanism.
        static void FirstLookAtTuples()
        {
            (int, string, double) salary = (2021, "Jule", 10025.5);
            Console.WriteLine($"First item: {salary.Item1}");
            Console.WriteLine($"Second item: {salary.Item2}");
            Console.WriteLine($"Third item: {salary.Item3}");
            Console.WriteLine();

            var juleSalary = (2021, "Jule", 10025.5);
            Console.WriteLine($"First item: {juleSalary.Item1}");
            Console.WriteLine($"Second item: {juleSalary.Item2}");
            Console.WriteLine($"Third item: {juleSalary.Item3}");
            Console.WriteLine();
        }

        // Specific names can also be added to each property in the tuple on either the right side or the left side of
        // the statement.While it is not a compiler error to assign names on both sides of the statement, if you do, the
        // right side will be ignored, and only the left-side names are used
        static void UseSpecificNamesAtTuples()
        {
            (int Year, string Month, double Salary) info = (2021, "Jule", 10025.5);
            var info2 = (Year: 2021, Month: "Jule", Salary: 10025.5);

            Console.WriteLine($"First item: {info.Year}");
            Console.WriteLine($"Second item: {info.Month}");
            Console.WriteLine($"Third item: {info.Salary}");
            Console.WriteLine();

            Console.WriteLine($"First item: {info2.Year}");
            Console.WriteLine($"Second item: {info2.Month}");
            Console.WriteLine($"Third item: {info2.Salary}");
            Console.WriteLine();

            //Using the item notation still works!
            Console.WriteLine($"First item: {info2.Item1}");
            Console.WriteLine($"Second item: {info2.Item2}");
            Console.WriteLine($"Third item: {info2.Item3}");
            Console.WriteLine();
        }

        static void UseNestedTuples()
        {
            Console.WriteLine("--------> Nested Tuples");
            var nt = (5, 4, ("a", "b"));
            Console.WriteLine($"First item: {nt.Item1}");
            Console.WriteLine($"Second item: {nt.Item2}");
            Console.WriteLine($"Third item: {nt.Item3.Item1}, {nt.Item3.Item2}");
            Console.WriteLine();
        }

        static void UsedTuplesAsMethodReturnValues()
        {
            var samples = UseTuplesAsMethodReturnValues();
            Console.WriteLine($"Int is: {samples.year}");
            Console.WriteLine($"String is: {samples.month}");
            Console.WriteLine($"Double is: {samples.salary}"); 
        }

        static (int year, string month, double salary) UseTuplesAsMethodReturnValues()
        {
            return (0, "January", 1000);
        }

        struct Point
        {
            public int X;
            public int Y;

            // A custom constructor.
            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }

            public (int XPos, int YPos) Deconstruct() => (X, Y);
        }

        // Deconstructing is the term given when separating out the properties of a tuple to be used individually.
        static void UseDeconstructingTuples()
        {
            Point p = new Point(7, 5);
            var pointValues = p.Deconstruct();
            Console.WriteLine($"\nX is: {pointValues.XPos}");
            Console.WriteLine($"Y is: {pointValues.YPos}");
        }
    }   
}