// Declare variables to store input and reversed output
string input, output = "";

// Prompt the user to enter a string
Console.Write("Enter a string: ");

// Read the user input and store it in the 'input' variable
input = Console.ReadLine();

// Iterate through each character in the input string in reverse order
for (int i = input.Length - 1; i >= 0; i--)
{
    // Concatenate each character to the 'output' string, effectively reversing the string
    output += input[i];
}

// Display the reversed string using string interpolation
Console.WriteLine($"Reversed is {output}");
