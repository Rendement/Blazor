

namespace Rendement.Blazor.UI.Interfaces
{
    public interface IStringService
    {
        string Concatenate(string str1, string str2);
        string? ToUpperCase(string? input);
        string? ToLowerCase(string? input);
        bool IsNullOrEmpty(string? input);
        int GetLength(string? input);
    }
}