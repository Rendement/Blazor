

namespace Rendement.Blazor.UI.Interfaces
{
    public interface IStringService : IParagraphService
    {
        string Concatenate(string str1, string str2);
        string? ToUpperCase(string? input);
        string? ToLowerCase(string? input);
        bool IsNullOrEmpty(string? input);
        int GetLength(string? input);
        string? GetSubstring(string? input, int startIndex, int length);
        string? GetSubstringFromStart(string? input, int length);
        string? GetSubstringFromEnd(string? input, int length);
        string? GetFirstCharacter(string? input);
        string? GetLastCharacter(string? input); 

    }
}