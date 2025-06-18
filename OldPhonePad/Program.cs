using System;

class Program
{
    static void Main()
    {
        RunTests();
    }

    static void RunTests()
    {
        int passed = 0;
        int total = 6;

        passed += Expect("E", OldPhone.mapStringToOldPhone("33#"), "Test 1: Simple letter");
        passed += Expect("B", OldPhone.mapStringToOldPhone("227*#"), "Test 2: Backspace");
        passed += Expect("HELLO", OldPhone.mapStringToOldPhone("4433555 555666#"), "Test 3: HELLO");
        passed += Expect("TURING", OldPhone.mapStringToOldPhone("8 88777444666*664#"), "Test 4: Complex");
        passed += Expect("", OldPhone.mapStringToOldPhone("#"), "Test 5: Empty input");
        passed += Expect("", OldPhone.mapStringToOldPhone("2*2*2*#"), "Test 6: Only backspaces");

        Console.WriteLine($"\nSummary: {passed}/{total} tests passed.");
    }

    static int Expect(string expected, string actual, string testName)
    {
        if (expected == actual)
        {
            Console.WriteLine($"{testName} passed");
            return 1;
        }
        else
        {
            Console.WriteLine($"{testName} failed — Expected: '{expected}' | Got: '{actual}'");
            return 0;
        }
    }
}
