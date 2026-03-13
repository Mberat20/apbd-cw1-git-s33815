using System;

Console.WriteLine("Welcome to the ULTIMATE Statistics Calculator!");
Console.WriteLine("Please enter a number to process:");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: Input cannot be empty. Please enter a valid number.");
    return;
}

Console.WriteLine($"You entered: {input}");