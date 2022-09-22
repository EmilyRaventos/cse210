using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Bill");
            names.Add("Sue");
            
            names.ForEach(name => Console.Write(name + " "));

            string a_string = "a";
            List<string> stuff = new List<string> { a_string, "b", "c", "d"};

            char aSingleCharacter = 'a';
            Console.WriteLine($"This is a single character: {aSingleCharacter}");

            int x = 5;
            int y = 7;
            int result = Adder(x, y); //12
            
            int result2 = Adder(10, 46); //56

            Console.WriteLine($"{x} + {y} = {result}");
        }

        // Create functions. For now start with static
        static int Adder(int a, int b)
        {
            return a + b;
        }

        // Notes about the tic-tac-toe program:
        
    }
}