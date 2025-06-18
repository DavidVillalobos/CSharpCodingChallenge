using Xunit;


public class OldPhoneTests
{
    [Theory]
    [InlineData("2", "A")]
    [InlineData("22", "B")]
    [InlineData("222", "C")]
    public void SingleKey_ReturnsCorrectLetter(string input, string expected)
    {
        string result = OldPhone.MapStringToOldPhone(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("44 444", "HI")]
    [InlineData("222 2 22", "CAB")]
    [InlineData("7777 666 2", "SOA")]
    public void MultipleKeys_ReturnsCorrectWord(string input, string expected)
    {
        string result = OldPhone.MapStringToOldPhone(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("2222", "A")]    // "ABC" → 4 → "A"
    [InlineData("77777", "P")]   // "PQRS" → 5 → "P"
    [InlineData("99999", "W")]   // "WXYZ" → 5 → "W"
    public void CyclicKeys_ReturnsCorrectLetter(string input, string expected)
    {
        string result = OldPhone.MapStringToOldPhone(input);
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData("2*", "")]
    [InlineData("22*2", "A")]
    [InlineData("222*22", "B")]
    public void Backspace_RemovesLastCharacter(string input, string expected)
    {
        string result = OldPhone.MapStringToOldPhone(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("2#", "A")]
    [InlineData("22#333", "B")]
    [InlineData("222#444", "C")]
    public void HashTerminator_StopsProcessing(string input, string expected)
    {
        string result = OldPhone.MapStringToOldPhone(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("0", " ")]
    [InlineData("1", "&")]
    [InlineData("11", "'")]
    public void SpecialKeys_ReturnsCorrectCharacter(string input, string expected)
    {
        string result = OldPhone.MapStringToOldPhone(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("   ", "")]
    public void EmptyInput_ReturnsEmpty(string input, string expected)
    {
        string result = OldPhone.MapStringToOldPhone(input);
        Assert.Equal(expected, result);
    }
}
