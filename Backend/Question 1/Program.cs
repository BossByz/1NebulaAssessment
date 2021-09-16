using System;

namespace Backend_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MULTIPLE OF 2 AND 4
            StackOverflow("Test");
            //MULTIEPLE OF JUST 2
            StackOverflow("Hi");
            //NOT A MULTIPLE OF 2 OR 4
            StackOverflow("Test2");
        }

        private static void StackOverflow(string input)
        {
            if (input.Length % 2 == 0) Console.WriteLine("Stack");

            if (input.Length % 4 == 0) Console.WriteLine("Overflow");

            if (input.Length % 2 == 0 && input.Length % 4 == 0) Console.WriteLine("Stack Overflow!");

            //FIRST ATTEMPT, DOES NOT FOLLOW EXACTLY WHAT THE QUESTION ASKS
            //return input.Length % 2 == 0 ?
            //    input.Length % 4 == 0 ? "Stack Overflow!" : "Stack"
            //    : "No Conditions Met";
        }
    }
}
