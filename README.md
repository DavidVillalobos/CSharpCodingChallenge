OldPhonePad – C# Coding Challenge
==================================

This is a solution to the **Old Phone Keypad** coding challenge. It interprets a string simulating button presses on a classic mobile phone keypad and converts it into the corresponding message.

Challenge Summary
------------------
Given a string of characters simulating key presses (e.g., "4433555 555666#"), return the decoded text based on old mobile phones:
- Pressing a key multiple times cycles through letters (e.g., 2 → A, B, C).
- Pauses (spaces) separate different letters pressed on the same key.
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
    dotnet run --project OldPhonePad

How to Run Tests
-----------------
This project uses **xUnit** for unit testing.

To run all tests:
    dotnet test

Test Coverage
--------------
Test coverage includes:
- Basic letter selection per key.
- Cyclic key presses (e.g., "77777" returns "P").
- Backspace functionality with `*`.
- Input termination with `#`.
- Special characters from key '1' and '0'.
- Edge cases for null or empty input.

Project Structure
------------------
OldPhonePad/
├── OldPhone.cs        → Core logic to interpret keypad inputs  
├── OldPhoneTests.cs   → Unit tests using xUnit  
├── OldPhonePad.csproj → Project file  
├── bin/               → Output binaries  
├── obj/               → Intermediate files  
└── README.txt         → Project documentation  

Contact
--------
Developed by David Villalobos as part of a technical assessment for IronSoftware.  
Feel free to reach out via email or GitHub for questions or improvements.
