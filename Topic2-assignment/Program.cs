namespace Topic2_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sammy
            Console.WriteLine("My birth year: " + (2026 - 16));
            Console.WriteLine();
            Console.WriteLine("Average of 14, 15, and 16: " + ((14 + 15 + 16) / 3));
            Console.WriteLine();
            Console.WriteLine("Average of 14, 15, 16, and 17: " + ((14 + 15 + 16 + 17) / 4.0));
            Console.WriteLine();
            Console.WriteLine("The area of a circle with a radius of 3 centimeters: " + Math.Round(3.141592653589 * (3 * 3), 2));
            Console.WriteLine();
            Console.WriteLine("C# knows when to add based on if you have text on one side of the operator or not.");
            Console.WriteLine("If you want math done with no such errors you must type +. Console.WriteLine(``random text`` + (2 + 2))");
            Console.WriteLine("If you didn't type the brackets, you'd get something like: random text2.");
        }
    }
}
