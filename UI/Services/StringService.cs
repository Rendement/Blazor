using Rendement.Blazor.UI.Interfaces;

namespace Rendement.Blazor.UI.Services
{
    public class StringService : IStringService
    {
        public string Concatenate(string str1, string str2)
        {
            return str1 + str2;
        }

        public string? ToUpperCase(string? input)
        {
            return input?.ToUpper();
        }

        public string? ToLowerCase(string? input)
        {
            return input?.ToLower();
        }

        public bool IsNullOrEmpty(string? input)
        {
            return string.IsNullOrEmpty(input);
        }

        public int GetLength(string? input)
        {
            return input?.Length ?? 0;
        }
    }

    
}