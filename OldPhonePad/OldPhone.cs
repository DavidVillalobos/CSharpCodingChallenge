using System;
using System.Text;
using System.Collections.Generic;

public class OldPhone
{
    // Key to letters mapping
    private static readonly Dictionary<char, string> KeypadMapping = new Dictionary<char, string>
    {
        {'1', "&'("}, {'2', "ABC"}, {'3', "DEF"},
        {'4', "GHI"}, {'5', "JKL"}, {'6', "MNO"},
        {'7', "PQRS"}, {'8', "TUV"},{'9', "WXYZ"},
        {'0', " "}
    };

    // Converts old phone keypad input to text
    public static string MapStringToOldPhone(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var result = new StringBuilder();
        int position = 0;

        while (position < input.Length)
        {
            char currentChar = input[position];

            // Stop at '#'
            if (currentChar == '#')
                break;

            // Handle backspace: remove last character
            if (currentChar == '*')
            {
                if (result.Length > 0)
                    result.Remove(result.Length - 1, 1);
                position++;
                continue;
            }

            // Skip spaces
            if (currentChar == ' ')
            {
                position++;
                continue;
            }

            // Count consecutive same characters
            int consecutiveCount = CountConsecutiveChars(input, position, currentChar);

            // Process valid key
            if (KeypadMapping.ContainsKey(currentChar))
            {
                string letters = KeypadMapping[currentChar];
                int letterIndex = (consecutiveCount - 1) % letters.Length;
                result.Append(letters[letterIndex]);
            }

            position += consecutiveCount;
        }

        return result.ToString();
    }

    // Counts consecutive identical characters from a position
    private static int CountConsecutiveChars(string input, int startPosition, char targetChar)
    {
        int count = 1;
        int position = startPosition + 1;

        while (position < input.Length && input[position] == targetChar)
        {
            count++;
            position++;
        }

        return count;
    }

    // Test method to verify functionality
    public static void TestMethod()
    {
        string[] testCases = {
            "44 444",           // "HI"
            "222 2 22",         // "CAB"  
            "7777 666 2 7777",  // "SOAP"
            "44 444*43",        // "HG" (with backspace)
            "2*#",              // "" (backspace and termination)
            "0 9 666 777 555 3" // " WORLD"
        };

        Console.WriteLine("Old phone tests:\n");

        foreach (var test in testCases)
        {
            string result = MapStringToOldPhone(test);
            Console.WriteLine($"Input: '{test}' → Output: '{result}'");
        }
    }
}