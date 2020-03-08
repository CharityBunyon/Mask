using System;

namespace Mask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masking Sensitive Information Exercise");
            Console.WriteLine("Hey you, tell me a secret!");
            var userInput = Console.ReadLine();

            if (userInput.Length > 4)
            {
                var result = userInput.Substring(userInput.Length - 4);
                Console.WriteLine(result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(userInput);
                Console.ReadLine();
            }
        }
    }
}
// Substring is part of the string class
// What I'm doing here is creating a child string of the string within the variable userInput.
// Then I'm taking the length(start value) of the userInput string and telling my app that I only want the last 4 characters of that string (end value)
// I have an else statement for if the userInput is less than 4 then it'll just print out the user's input