Console.WriteLine("Welcome to the Statistics Calculator");
Console.WriteLine("Please enter a number to process:");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error:Input can not be empty.Please try again");
    return;
}
Console.WriteLine($"Input: {input}");