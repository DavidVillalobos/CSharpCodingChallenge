OldPhonePad – C# Coding Challenge
==================================================

This is a solution to the **Old Phone Keypad** coding challenge. It interprets a string simulating button presses on a classic mobile phone keypad and converts it into the corresponding message.

Challenge Summary
------------------
Given a string of characters simulating key presses (e.g., "4433555 555666#"), return the decoded text based on old mobile phones:
- Pressing a key multiple times cycles through letters (e.g., 2 → A, B, C).
- Pauses (space) separate different letters on the same key.
- Asterisk (*) acts as backspace.
- Hash (#) marks the end of input.

Example Inputs
--------------
Input: "33#"                         → Output: E
Input: "227*#"                       → Output: B
Input: "4433555 555666#"             → Output: HELLO
Input: "8 88777444666*664#"          → Output: TURING

Requirements
-------------
- .NET 8 SDK (https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

To check your version:
    dotnet --version

How to Run
-----------
1. Clone the repository:
    git clone https://github.com/DavidVillalobos/CSharpCodingChallenge
    cd OldPhonePad

2. Build the project:
    dotnet build

3. Run the program:
    dotnet run

Test Coverage
--------------
Instead of using an external testing framework, all test cases are executed from Main() and output clearly in the console for ease of review.

Project Structure
------------------
OldPhonePad/
├── Program.cs         → Entry point with integrated tests
├── OldPhone.cs        → Challenge logic
├── OldPhonePad.csproj
└── README.txt

Contact
--------
Developed by David Villalobos as part of a technical assessment for IronSoftware.
Feel free to reach out via email or GitHub for questions.
