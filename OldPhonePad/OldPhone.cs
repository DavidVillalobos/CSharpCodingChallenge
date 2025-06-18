using System;
using System.Text;
using System.Collections.Generic;

class OldPhone
{
    // Converts an input string simulating an old phone keypad into the resulting text
    public static string mapStringToOldPhone(string x)
    {
        StringBuilder s = new StringBuilder(); // Final output
        int a = 0; // Position index for the input string

        // Mapping each keypad digit to its corresponding letters
        Dictionary<char, string> d = new Dictionary<char, string>();
        d.Add('1', "&'(");
        d.Add('2', "ABC");
        d.Add('3', "DEF");
        d.Add('4', "GHI");
        d.Add('5', "JKL");
        d.Add('6', "MNO");
        d.Add('7', "PQRS");
        d.Add('8', "TUV");
        d.Add('9', "WXYZ");
        d.Add('0', " ");

        // Loop through the input string Length
        while (a < x.Length)
        {
            char c = x[a]; // get letter at position a

            // Stop processing at '#'
            if (c == '#') break;

            // Handle backspace: remove the last character from the output
            if (c == '*')
            {
                if (s.Length > 0)
                {
                    s.Remove(s.Length - 1, 1);
                }
                a++;
                continue;
            }

            // Skip pauses (space separates repeated presses on same key)
            if (c == ' ')
            {
                a++;
                continue;
            }

            // Count how many times the same key is pressed consecutively
            int b = a;
            while (b + 1 < x.Length && x[b + 1] == c)
            {
                b++;
            }

            int e = b - a + 1; // Number of repeated key presses

            // If the character is a valid key in the mapping
            if (d.ContainsKey(c))
            {
                /* Get corresponding letters for the key Calculate letter index (cycles if over) Append the letter to the output */
                string f = d[c];
                int g = (e - 1) % f.Length;
                s.Append(f[g]);
            }

            a = b + 1;
        }

        return s.ToString();
    }
}
